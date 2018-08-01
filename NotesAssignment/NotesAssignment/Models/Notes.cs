using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotesAssignment.Models
{
    public class Notes
    {
        public string Title { get; set; }
        public string PlainText { get; set; }
        public List<string> CheckList { get; set; }
        public List<string> Labels { get; set; }
        public bool PinStatus { get; set; }
    }
}
