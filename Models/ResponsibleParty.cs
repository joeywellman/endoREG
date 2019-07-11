using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace endoREG_MVC.Models
{
    public class ResponsibleParty
    {
        [Key]
        public int ResponsiblePartyId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateAssigned { get; set; }

        [Display(Name = "Inactive?")]
        public bool Inactive { get; set; }

        [Required]
        [StringLength(55, ErrorMessage = "Please enter less than 55 characters")]
        public string NameOrGroup { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Please enter less than 20 characters")]
        public string NameOrGroupNumber { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        public ICollection<Completion> Completions { get; set; }
        //public object ApplicationUser { get; internal set; }
    }
}
