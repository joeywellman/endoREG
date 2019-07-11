using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace endoREG_MVC.Models
{
    public class GroupedActionItems
    {
        public int TopicId { get; set; }
        public string TopicName { get; set; }
        public int ActionItemCount { get; set; }
        public IEnumerable<ActionItem> ActionItems { get; set; }
    }
}
