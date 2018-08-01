using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleKeepAssignment.Models
{
    public class Note
    {
        public Note()
        {
            this.CheckLists = new HashSet<CheckList>();
            this.Labels = new HashSet<Label>();
        }
        public string Title { get; set; }
        public string PlainText { get; set; }
        public bool PinStatus { get; set; }
        public virtual ICollection<CheckList> CheckLists { get; set; }
        public virtual ICollection<Label> Labels { get; set; }
    }
}
