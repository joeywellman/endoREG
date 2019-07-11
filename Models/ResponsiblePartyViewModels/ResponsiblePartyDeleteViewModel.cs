using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace endoREG_MVC.Models.ResponsiblePartyViewModels
{
    public class ResponsiblePartyDeleteViewModel
    {
        public ResponsibleParty ResponsibleParty { get; set; }

        public ResponsiblePartyDeleteViewModel(ResponsibleParty responsibleParty)
        {
            ResponsibleParty = responsibleParty;
        }
    }
}
