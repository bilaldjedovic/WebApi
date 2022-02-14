using System.ComponentModel.DataAnnotations;

namespace WebApi
{
    public class Song
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string songName { get; set; } = string.Empty;

        [StringLength(300)]
        public string link { get; set; } = string.Empty;
        public int categoryId { get; set; }

        public Category? category { get; set; }

        [StringLength(50)]
        public string author { get; set; } = string.Empty;


        public int rate { get; set; }


        public bool favorite { get; set; } = false;


        public DateTime createdAt { get; set; }


        public DateTime modifiedAt { get; set; }

    }
}