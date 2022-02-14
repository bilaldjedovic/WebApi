
using System.ComponentModel.DataAnnotations;

namespace WebApi
{
    public class Category
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string category { get; set; } = string.Empty;


    }
}