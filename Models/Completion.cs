using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace endoREG_MVC.Models
{
    public class Completion
    {
        [Key]
        public int CompletionId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateCompleted { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        public int? ResponsiblePartyId { get; set; }
        public ResponsibleParty ResponsibleParty { get; set; }

        public virtual ICollection<CompletionActionItem> CompletionActionItems { get; set; }

    }
}
