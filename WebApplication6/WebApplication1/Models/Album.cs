using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Album
    {
        public int Id { get; set; }
        [Required]
        [StringLength(60,MinimumLength =20)]
        public string Artist { get; set; }
        public string Name { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string Genre { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [Range(0,100)]
        public decimal Price { get; set; }
        public int Rank { get; set; }
    }
}
