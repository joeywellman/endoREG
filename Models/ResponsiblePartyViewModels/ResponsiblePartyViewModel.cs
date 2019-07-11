using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace endoREG_MVC.Models.ResponsiblePartyViewModels
{
    public class ResponsiblePartyViewModel
    {
        public ResponsibleParty parties { get; set; }

        public SelectList responsibleParties { get; set; }
    }

}
