using System.ComponentModel.DataAnnotations;

namespace TechJobs6Persistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage ="this field most be fill out")]
        public string? Name { get; set; }
        [Required(ErrorMessage ="This field most be fill out")]
        [StringLength(150, MinimumLength =4, ErrorMessage ="This is not a valid addres")]
        public string? Location { get; set; }    
    }
}

