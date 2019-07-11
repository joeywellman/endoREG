using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace endoREG_MVC.Models
{
    public class CompletionActionItem
    {
        [Key]
        public int CompletionActionItemId { get; set; }

        [Required]
        public int CompletionId { get; set; }

        public Completion Completion { get; set; }

        [Required]
        public int ActionItemId { get; set; }

        public ActionItem ActionItem { get; set; }

    }
}
