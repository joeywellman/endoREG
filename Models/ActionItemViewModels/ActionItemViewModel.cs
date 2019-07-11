using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace endoREG_MVC.Models.ActionItemViewModels
{
    public class ActionItemViewModel
    {
        public ActionItem actionItem { get; set; }

        public SelectList compliancePlans { get; set; }

        public IFormFile ActionItemImage { get; set; }

    }
}
