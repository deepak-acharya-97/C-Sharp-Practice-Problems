using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleKeepWithMigration.Models
{
    public class Notes
    {
        [Key]
        public string Title { get; set; }
        public string PlainText { get; set; }
        public List<string> CheckLists { get; set; }
        public List<string> Labels { get; set; }
        public bool PinStatus { get; set; }
    }
}
