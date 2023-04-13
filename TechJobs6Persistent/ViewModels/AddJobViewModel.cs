using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using TechJobs6Persistent.Models;

namespace TechJobs6Persistent.ViewModels
{
    public class AddJobViewModel
    {
        

        [Required(ErrorMessage ="This field can't be empty")]
        [StringLength(55, MinimumLength = 4, ErrorMessage ="This job name is to short")]
        public string? JobName { get; set; }
        [Required(ErrorMessage ="EMPLOYER REQUIRED")]
        public int EmployerId { get; set; }
        public List<SelectListItem>? Employers { get; set; }

        public AddJobViewModel()
        {

        }
        public AddJobViewModel(List<Employer> possibleJobs)
        {
            Employers = new List<SelectListItem>();

            foreach (var employer in possibleJobs)
            {
                Employers.Add(new SelectListItem
                {
                    Text= employer.Name,
                    Value = employer.Id.ToString()
                });
            }

         
        }

    }

}
