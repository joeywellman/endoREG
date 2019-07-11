using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace endoREG_MVC.Models
{
    public class ActionItem
    {
        [Key]
        [Display(Name = "Action Item")]
        public int ActionItemId { get; set; }

        [Required]
        [Display(Name = "Date Assigned")]
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateAssigned { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Please enter a Description less than 500 characters")]
        public string Description { get; set; }

        [Required]
        [StringLength(150, ErrorMessage = "Please shorten the Action Item Title to 150 characters")]
        [Display(Name = "Title / Reference")]
        public string Title { get; set; }

        [Required]
        //[DisplayFormat(DataFormatString = "{0:C}")]
        public int Weight { get; set; }

        [Display(Name = "Days to Complete")]
        [Required(ErrorMessage = "Please enter Number of Days to complete")]
        public int DaysToComplete { get; set; }

        [Display(Name = "User ID #")]
        [Required]
        public string UserId { get; set; }

        public string Location { get; set; }

        [Display(Name = "Action Item Picture")]
        public byte[] ActionItemImage { get; set; }

        [Display(Name = "Mark Complete")]
        public bool Complete { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        [Required(ErrorMessage = "Please choose a Compliance Plan")]
        [Display(Name = "Compliance Plan")]
        public int CompliancePlanId { get; set; }

        [Display(Name = "Compliance Plan")]
        public CompliancePlan CompliancePlan { get; set; }

        [Display(Name = "Is Action Item Active?")]
        public bool IsActive { get; set; }

        public virtual ICollection<CompletionActionItem> CompletionActionItems { get; set; }

        public ActionItem()
        {
            Complete = false;
        }

    }
}
