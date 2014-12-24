using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Ninject;
using Prizm.Domain.Entity.Mill;
using System.ComponentModel;

namespace Prizm.Data.DAL.ADO
{
    public class MillReportsRepository : IMillReportsRepository
    {
        [Inject]
        public MillReportsRepository() { }
        private SqlConnection connection = null;

        public DataSet GetPipesByStatus(DateTime startDate, DateTime finalDate, List<Guid> categories, ReportType reportType, List <string> statuses, bool previewFlag = false)
        {
            CreateConnection();
            DataSet pipeDataSet = new DataSet();

            try
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {

                    using (SqlCommand command = new System.Data.SqlClient.SqlCommand())
                    {
                        connection.Open();
                        adapter.TableMappings.Add("Table", "Pipe");
                        command.Connection = connection;

                        //input search criteria value
                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@finalDate", finalDate);
                        
                        //temporary SQLobject
                        ISQLFlexible tempSQLObject;
                        
                        switch (reportType)
                        {
                            case ReportType.ByCategories:
                                {
                                    var categoryParameters = new string[categories.Count];
                                    for (int i = 0; i < categories.Count; i++)
                                    {
                                        categoryParameters[i] = string.Format("@Category{0}", i);
                                        command.Parameters.AddWithValue(categoryParameters[i], categories[i]);
                                    }

                                    var statusParameters = new string[statuses.Count];
                                    for (int j = 0; j < statuses.Count; j++)
                                    {
                                        statusParameters[j] = string.Format("@Status{0}", j);
                                        command.Parameters.AddWithValue(statusParameters[j], statuses[j]);
                                    }


                                    tempSQLObject = SQLProvider.GetQuery("GetAllActivePipesByDate").WhereAnd()..Where("Pipe.isActive","=","1").WhereAnd().WhereRequired("PipeTest.isRequred","=","1");
                                                                                                              
                                    if (previewFlag)
                                    {
                                        tempSQLObject.Top(1);
                                    }

                                    
                                    tempSQLObject = (categories.Count != 0) ? tempSQLObject.WhereAnd().Where("PipeTest.categoryId","IN",  "("+string.Join(", ", categoryParameters)+")")
                                                                                 : tempSQLObject;
                                    if(statuses.Count!=0)
                                        tempSQLObject = tempSQLObject.WhereAnd().Where("PipeTestResult.status", "IN", "("+string.Join(", ", statusParameters)+")");

                                    command.CommandText =tempSQLObject.ToString(); 

                                }; break;
                            case ReportType.ByProducing:

                                tempSQLObject = SQLProvider.GetQuery("GetAllProduced").WhereAnd().Where("PipeMillStatus","=","Produced").WhereAnd().Where("Pipe.isActive","=","1");
                                if (previewFlag)
                                    {
                                        tempSQLObject.Top(1);
                                    }
                                command.CommandText =tempSQLObject.ToString(); 
                                break;
                            case ReportType.ByShipped:
                                tempSQLObject = SQLProvider.GetQuery("GetAllShipped").WhereAnd().Where("PipeMillStatus","=","Shipped").WhereAnd().Where("Pipe.isActive","=","1");
                                    if (previewFlag)
                                    {
                                        tempSQLObject.Top(1);
                                    }
                                command.CommandText =tempSQLObject.ToString();
                                break;
                            default:
                                { throw new Exception("Cannot form query"); }
                        }
                        adapter.SelectCommand = command;
                        adapter.Fill(pipeDataSet);
                    }
                }

            }
            catch (SqlException ex)
            {
                throw new RepositoryException("GetPipesByStatus", ex);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return pipeDataSet;
        }

        public DataTable GetAuditResults(DateTime startDate, DateTime finalDate, string user)
        {
            CreateConnection();
            DataTable auditDataTable = new DataTable();
            try
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {

                    using (SqlCommand command = new System.Data.SqlClient.SqlCommand())
                    {
                        connection.Open();
                        adapter.TableMappings.Add("Table", "AuditLog");
                        command.Connection = connection;
                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@finalDate", finalDate);
                        command.Parameters.AddWithValue("@user", user);
                        command.CommandText = SQLQueryString.GetAudit;
                        adapter.SelectCommand = command;
                        adapter.Fill(auditDataTable);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new RepositoryException("GetAuditResults", ex);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return auditDataTable;
        }

        public DataSet GetPipesFromInspection(DateTime startDate, DateTime finalDate)
        {
            CreateConnection();
            DataSet pipeDataSet = new DataSet();

            try
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {

                    using (SqlCommand command = new System.Data.SqlClient.SqlCommand())
                    {
                        connection.Open();
                        adapter.TableMappings.Add("Table", "Pipe");
                        command.Connection = connection;
                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@finalDate", finalDate);
                        command.CommandText = SQLQueryString.GetAllPipesFromInspection;
                        adapter.SelectCommand = command;
                        adapter.Fill(pipeDataSet);
                    }
                }

            }
            catch (SqlException ex)
            {
                throw new RepositoryException("GetPipesFromInspection", ex);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return pipeDataSet;
        }

        public DataSet GetUsedProducts(int startPK, int endPK, string queryString)
        {
            CreateConnection();
            DataSet pipeDataSet = new DataSet();

            try
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {

                    using (SqlCommand command = new System.Data.SqlClient.SqlCommand())
                    {
                        connection.Open();
                        adapter.TableMappings.Add("Table", "Joint");
                        command.Connection = connection;
                        command.Parameters.AddWithValue("@startPK", startPK);
                        command.Parameters.AddWithValue("@endPK", endPK);
                        command.CommandText = queryString;
                        adapter.SelectCommand = command;
                        adapter.Fill(pipeDataSet);
                    }
                }

            }
            catch (SqlException ex)
            {
                throw new RepositoryException("Get Used Products", ex);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return pipeDataSet;
        }

        public DataTable GetPipelineElements()
        { 
         CreateConnection();
            DataTable resultsTable = new DataTable();
            try
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {

                    using (SqlCommand command = new System.Data.SqlClient.SqlCommand())
                    {
                        connection.Open();
                        command.Connection = connection;
                        command.CommandText = SQLQueryString.GetPipelinePieces;
                        adapter.SelectCommand = command;
                        adapter.Fill(resultsTable);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new RepositoryException("GetAuditResults", ex);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return resultsTable;
        }

        public SqlConnection CreateConnection()
        {
            if (connection == null)
            {
                ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["PrizmDatabase"];
                connection = new System.Data.SqlClient.SqlConnection(settings.ConnectionString);
            }

            return connection;
        }

        public BindingList<int> GetAllKP() 
        {
            CreateConnection();
            BindingList<int> PKList = new BindingList<int>();
         
            try
            {
                using (SqlCommand command = new System.Data.SqlClient.SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = SQLQueryString.GettAllKP;
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {  
                        PKList.Add((int)dr[0]);
                    }
                }

              
            }
            catch (SqlException ex)
            {
                throw new RepositoryException("Get Used Products", ex);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return PKList;
        }

    }
}
