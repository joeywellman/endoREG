using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace endoREG_MVC.Models.ReportItems
{
    public class ActionItemsReportItem
    {
        [Display(Name = "Action Items")]
        public ActionItem ActionItems { get; set; }

        [Display(Name = "Total Action Items Completed")]
        public int TotalCompletions { get; set; }
    }
}
