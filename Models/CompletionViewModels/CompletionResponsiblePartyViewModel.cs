using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace endoREG_MVC.Models.CompletionViewModels
{
    public class CompletionResponsibleParty
    {
        public Completion Completion { get; set; }

        public IEnumerable<CompletionLineItem> LineItems { get; set; }

        public SelectList UserResonsiblePartyGroup { get; set; }
    }
}