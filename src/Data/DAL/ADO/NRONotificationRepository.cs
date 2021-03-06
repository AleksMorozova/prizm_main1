﻿using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Mill;
using Prizm.Domain.Entity.Setup;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.ADO
{
    public class NRONotificationRepository : INRONotificationRepository, IDisposable
    {
        private SqlConnection connection = null;

        /// <summary>
        ///  Read size types + not required inspection operations, from settings.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns>
        /// List of NotRequiredOperation
        /// </returns>
        public List<NotRequiredOperation> GetAllNotRequiredOperation()
        {
            CreateConnection();
            List<NotRequiredOperation> inspectionOperations = new List<NotRequiredOperation>();

            try
            {
                using (SqlCommand command = new System.Data.SqlClient.SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;

                    command.CommandText = String.Format( @"Select s.id, t.id, t.code,t.name,t.frequency,t.frequencyMeasure, s.type
                                                    From PipeTest t, PipeMillSizeType s 
                                                    where t.frequencyType = '{0}' and t.pipeMillSizeTypeId=s.id", InspectionFrequencyType.U.ToString() );

                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        inspectionOperations.Add(new NotRequiredOperation()
                        {
                            PipeSizeTypeId = (Guid)dr[0],
                            OperationId = (Guid)dr[1],
                            OperationCode=(string)dr[2],
                            OperationName = (string)dr[3],
                            Frequency = (int)dr[4],
                            Measure = (string)dr[5],// EnumWrapper not available there
                            PipeSizeTypeName = (string)dr[6]
                        });
                    }
                }


            }
            catch (SqlException ex)
            {
                throw new RepositoryException("Get all not required operation", ex);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return inspectionOperations;
        }

        /// <summary>
        /// Read all MAX dates including NULL, ordering by not required inspection operations, in pipe test result
        /// </summary>
        /// <param name="number"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns>
        /// List of KeyValuePair contains: date of last inspection result and id of not required inspection operations
        /// </returns>
        public List<KeyValuePair<DateTime, Guid>> GetAllNotRequiredOperationResult()
        {
            CreateConnection();
            List<KeyValuePair<DateTime, Guid>> inspectionOperationsResult = new List<KeyValuePair<DateTime, Guid>>();

            try
            {
                using (SqlCommand command = new System.Data.SqlClient.SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;

                    command.CommandText = String.Format (@"Select r.Date, t.id From PipeTest t
full join 
(Select Max(PipeTestResult.Date) date,PipeTestResult.pipeTestId testId 
From PipeTestResult PipeTestResult where  PipeTestResult.status not in('{0}')
 group by PipeTestResult.pipeTestId) r on r.testId=t.id where t.frequencyType ='{1}'
", PipeTestResultStatus.Scheduled.ToString(), InspectionFrequencyType.U.ToString());

                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        inspectionOperationsResult.Add(new KeyValuePair<DateTime, Guid>(
                        dr[0] == System.DBNull.Value ? (DateTime)(new DateTime(1950, 6, 10, 15, 24, 16)) : (DateTime)dr[0],
                        (Guid)dr[1]
                        ));
                    }
                }


            }
            catch (SqlException ex)
            {
                throw new RepositoryException("Get all not required operation", ex);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return inspectionOperationsResult;
        }

        /// <summary>
        /// Read all "unitsProducedSinceLastDate" for not required inspection operations.
        /// </summary>
        /// <param name="testId">
        /// Id of not required inspection operations
        /// </param>
        /// <param name="maxDate">
        /// date of last result of not required inspection operations
        /// </param>
        /// <param name="measure">
        /// Frequency measure of not required inspection operations
        /// </param>
        /// <returns>
        /// KeyValuePair contains id of not required inspection operations and units left since last inspection result
        /// </returns>
        public KeyValuePair<Guid, decimal> GetAllUnitsProducedSinceLastDate(Guid testId, DateTime maxDate, FrequencyMeasure measure)
        {
            CreateConnection();
            KeyValuePair<Guid, decimal> unitsProducedSinceLastDate = new KeyValuePair<Guid,decimal>();

            try
            {
                using (SqlCommand command = new System.Data.SqlClient.SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@testId", testId);
                    command.Parameters.AddWithValue("@maxDate", maxDate);

                    if (measure == FrequencyMeasure.Pipes)
                    {
                        command.CommandText = @"Select count(Distinct(p.number)) amount, t.id 
                                                From Pipe p, PipeTest t where t.pipeMillSizeTypeId=p.typeId and
                                                        t.id =@testId and p.productionDate>@maxDate and p.isActive=1 
                                                            group by   t.id ";
                        SqlDataReader dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            unitsProducedSinceLastDate = new KeyValuePair<Guid, decimal>(

                                (Guid)dr[1],
                                dr[0] == System.DBNull.Value ? 0 : (decimal)(int)dr[0]
                            );
                        }

                    }
                    else if (measure == FrequencyMeasure.Tons)
                    {
                        command.CommandText = @"select sum (w.amount) from (Select Distinct(p.weight) amount, t.id
  From Pipe p, PipeTest t where t.pipeMillSizeTypeId=p.typeId and
              t.id =@testId and p.productionDate>@maxDate and p.isActive=1 
                             group by   t.id, p.weight ) w group by w.id";
                        SqlDataReader dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            unitsProducedSinceLastDate = new KeyValuePair<Guid, decimal>(

                                (Guid)dr[1],
                                dr[0] == System.DBNull.Value ? 0 : (decimal)dr[0]

                            );
                        }
                    }

                    else if (measure == FrequencyMeasure.Meters)
                    {
                        command.CommandText = @"select sum (w.amount) from (Select Distinct(p.length) amount, t.id
                                                        From Pipe p, PipeTest t where t.pipeMillSizeTypeId=p.typeId and
                                                t.id =@testId and p.productionDate>@maxDate and p.isActive=1 
                                            group by   t.id, p.weight ) w group by w.id";

                        SqlDataReader dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            unitsProducedSinceLastDate = new KeyValuePair<Guid, decimal>
                                ((Guid)dr[1],
                                dr[0] == System.DBNull.Value ? 0 : (decimal)(int)dr[0]);
                        }
                    }
                    else 
                    {
                        command.CommandText = @"Select 0 amount, t.id 
                                                From Pipe p, PipeTest t where t.pipeMillSizeTypeId=p.typeId and
                                                        t.id =@testId and p.productionDate>@maxDate and p.isActive=1 
                                                            group by   t.id ";
                        SqlDataReader dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            unitsProducedSinceLastDate = new KeyValuePair<Guid, decimal>
                                ((Guid)dr[1],
                                dr[0] == System.DBNull.Value ? 0 : (decimal)(int)dr[0]);
                        }
                    }
                }
            }

            catch (SqlException ex)
            {
                throw new RepositoryException("Get all not required operation", ex);
            }

            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return unitsProducedSinceLastDate;
        }

        public SqlConnection CreateConnection()
        {
            if (connection == null)
            {
                ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["PrismDatabase"];
                connection = new System.Data.SqlClient.SqlConnection(settings.ConnectionString);
            }

            return connection;
        }

        public void Dispose()
        {
            try
            {
                connection.Dispose();
            }
            catch (SqlException ex)
            {
                throw new RepositoryException("Dispose", ex);
            }
        }

        /// <summary>
        /// Find last date of inspection operation result and read all "unitsProducedSinceLastDate" for not required inspection operations.
        /// </summary>
        /// <param name="testId">
        /// Id of not required inspection operations
        /// </param>
        /// <param name="measure">
        /// Frequency measure of not required inspection operations
        /// </param>
        /// <returns>
        /// KeyValuePair contains id of not required inspection operations and units left since last inspection result 
        /// </returns>
        public KeyValuePair<Guid, decimal> GetUnitsProducedSinceLastDateTest(Guid testId, FrequencyMeasure measure)
        {
            CreateConnection();
            KeyValuePair<Guid, decimal> unitsProducedSinceLastDate = new KeyValuePair<Guid, decimal>();
            DateTime date=DateTime.MinValue;

            try
            {
                using (SqlCommand command = new System.Data.SqlClient.SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@testId", testId);

                    command.CommandText = String.Format(@"Select Max(r.Date) From PipeTestResult r Where r.pipeTestId = @testId 
and r.status not in('{0}')", PipeTestResultStatus.Scheduled.ToString());

                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        date = dr[0]== System.DBNull.Value ? (DateTime)(new DateTime(1950, 6, 10, 15, 24, 16)) : (DateTime)dr[0];
                    }

                    command.Parameters.AddWithValue("@testId", testId);
                    command.Parameters.AddWithValue("@date", date);

                    if (measure == FrequencyMeasure.Pipes)
                    {
                        command.CommandText = @"Select count(Distinct(p.number)) amount, t.id 
                                                From Pipe p, PipeTest t where t.pipeMillSizeTypeId=p.typeId and
                                                        t.id =@testId and p.productionDate>@maxDate and p.isActive=1 
                                                            group by   t.id ";
                       
                        while (dr.Read())
                        {
                            unitsProducedSinceLastDate = new KeyValuePair<Guid, decimal>(

                                testId,
                                dr[0] == System.DBNull.Value ? 0 : (decimal)(int)dr[0]
                            );
                        }

                    }
                    else if (measure == FrequencyMeasure.Tons)
                    {
                        command.CommandText = @" select sum (w.amount) from (Select Distinct(p.weight) amount, t.id
                                                        From Pipe p, PipeTest t where t.pipeMillSizeTypeId=p.typeId and
                                                                  t.id =@testId and p.productionDate>@maxDate and p.isActive=1 
                                                                          group by   t.id, p.weight ) w group by w.id ";
                       
                        while (dr.Read())
                        {
                            unitsProducedSinceLastDate = new KeyValuePair<Guid, decimal>(

                                testId,
                                dr[0] == System.DBNull.Value ? 0 : (decimal)(double)dr[0]

                            );
                        }
                    }

                    else if (measure == FrequencyMeasure.Meters)
                    {
                        command.CommandText = @" select sum (w.amount) from (Select Distinct(p.length) amount, t.id
                                                        From Pipe p, PipeTest t where t.pipeMillSizeTypeId=p.typeId and
                                                                  t.id =@testId and p.productionDate>@maxDate and p.isActive=1 
                                                                          group by   t.id, p.weight ) w group by w.id ";

                        
                        while (dr.Read())
                        {
                            unitsProducedSinceLastDate = new KeyValuePair<Guid, decimal>
                                (testId,
                                dr[0] == System.DBNull.Value ? 0 : (decimal)(int)dr[0]);
                        }
                    }
                    else
                    {
                        command.CommandText = @" Select 0 amount,  t.id 
                                                            From Pipe p, PipeTest t, PipeTestResult r 
                                                            where t.pipeMillSizeTypeId=p.typeId and t.id =@testId
                                                                and p.isActive=1 and t.id=r.pipeTestId and p.productionDate>@date
                                                                            group by  t.id ";
                
                        while (dr.Read())
                        {
                            unitsProducedSinceLastDate = new KeyValuePair<Guid, decimal>
                                (testId,
                                dr[0] == System.DBNull.Value ? 0 : (decimal)(int)dr[0]);
                        }
                    }
                }
            }

            catch (SqlException ex)
            {
                throw new RepositoryException("Get all units produced fr current test", ex);
            }

            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return unitsProducedSinceLastDate;
        }
    }
}
