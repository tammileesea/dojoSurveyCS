using System.ComponentModel.DataAnnotations;

namespace dojoSurvey.Models{
    public class Dojo{
        [Required]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Favorite Location")]
        public string Location { get; set; }

        [Required]
        [Display(Name = "Favorite Language")]
        public string Language { get; set; }

        [MinLength(20, ErrorMessage = "Comment must be at least 20 characters")]
        [Display(Name = "Comment")]
        public string Comment { get; set; }
    }
}