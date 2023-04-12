using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using TechJobs6Persistent.Models;

namespace TechJobs6Persistent.ViewModels
{
    public class AddJobViewModel
    {
        public int EmployerId { get; set; }

        [Required(ErrorMessage ="This field can't be empty")]
        [StringLength(55, MinimumLength = 10, ErrorMessage ="This job name is to short")]
        public string? JobName { get; set; }
        public List<SelectListItem>? Employers { get; set; }

        public AddJobViewModel(List<Employer> possibleJobs)
        {
            Employers = new List<SelectListItem>();

            foreach (var employer in possibleJobs)
            {
                Employers.Add(new SelectListItem
                {
                    Value = employer.Name,                  
                });
            }

         
        }

    }

}
