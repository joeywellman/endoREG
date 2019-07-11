using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace endoREG_MVC.Models.SimpleReportViewModels
{
    public class SimpleReportViewModel
    {
        public string DimensionOne { get; set; }
        public int Quantity { get; set; }

        public virtual ICollection<CompliancePlan> CompliancePlans { get; set; }

        public virtual ICollection<ActionItem> ActionItems { get; set; }

    }
}