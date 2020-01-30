using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Lesson8.Dal;

namespace Lesson8Project.Models
{
    public class ReportModel
    {
        private ReportAdapter adapter = new ReportAdapter();

        public List<Report> ReportRows
        {
            get;
            set;
        }

        public void PopulateReport()
        {
            ReportRows = adapter.GetReportRows();
        }
    }
}