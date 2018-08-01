using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleKeepAssignment.Models
{
    public class CheckList
    {
        public string CheckListData { get; set; }
        public bool CheckListStatus { get; set; }
        public string Title { get; set; }
        public virtual Note Note { get; set; }
    }
}
