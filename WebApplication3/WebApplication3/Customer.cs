using System.ComponentModel.DataAnnotations;

namespace WebApplication3
{
    public class Customer
    {
        public int Id { get; set; }
        [Required, StringLength(40)]
        public string Name { get; set; }
    }
}