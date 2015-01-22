﻿using Prizm.Data.DAL;
using Prizm.Data.DAL.ADO;
using Prizm.Domain.Entity.Setup;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Reports.Construction.PipeReport
{
    public class PreviewPipeReportCommand : ICommand
    {
        readonly IMillReportsRepository repo;
        readonly PipeConstractionReportViewModel viewModel;
        readonly IUserNotify notify;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public PreviewPipeReportCommand(
            PipeConstractionReportViewModel viewModel, 
            IMillReportsRepository repo, 
            IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repo = repo;
            this.notify = notify;
        }

        public void Execute()
        {
            viewModel.Data = repo.GetPipelineElements(
                viewModel.PipeNumber, 
                viewModel.CheckedPipeTypes.Select<PipeMillSizeType, string>(x => x.Type).ToArray<string>());

            var report = new PipeConstructionXtraReport();

            report.DataSource = viewModel.PipeReportDataList;
            report.CreateDocument();
            viewModel.PreviewSource = report;

            RefreshVisualStateEvent();
        }

        public bool CanExecute()
        {
            return true;
        }

    }
}