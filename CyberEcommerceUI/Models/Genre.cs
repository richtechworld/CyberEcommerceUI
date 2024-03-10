using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CyberEcommerceUI.Models
{
    [Table("Genre")]
    public class Genre
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string GenreName { get; set; }
        public List<Genre> Genres { get; set; }
    }
}
