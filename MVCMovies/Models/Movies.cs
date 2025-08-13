using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCMovies.Models
{
    public class Movies
    {

        public int ID { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "The Title field is required!")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "The Release Date field is required!")]
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseData { get; set; }

        [Required(ErrorMessage = "The Gender field is required!"), 
         StringLength(20),
         RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Only letters available in this field!")]
        public string Gender { get; set; } = string.Empty;

        [Required(ErrorMessage = "The Price field is required!")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Range(0,5)]
        [Required(ErrorMessage = "The Rate field is required!")]
        public int Rate { get; set; }
    }
}
