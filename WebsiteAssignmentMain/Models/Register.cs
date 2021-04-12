using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteAssignmentMain.Models
{
    public class Register
    {
        [Required(ErrorMessage ="*")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "*")]
        public string Password { get; set; }

        [Required(ErrorMessage = "*")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "*")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "*")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "*")]
        public DateTime BirthDate { get; set; }
    }
}
