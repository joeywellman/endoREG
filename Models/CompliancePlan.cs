using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace endoREG_MVC.Models
{
    public class CompliancePlan
    {
        [Key]
        public int CompliancePlanId { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Compliance Plan")]
        public string Label { get; set; }

        [NotMapped]
        public int DaysToComplete { get; set; }

        public virtual ICollection<ActionItem> ActionItems { get; set; }

    }
}