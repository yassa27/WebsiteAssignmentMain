using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteAssignmentMain.Models
{
    public class Register
    {
        [Required(ErrorMessage ="Username required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password required twice")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password required twice")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Email required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Name required")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Birthdate required")]
        public DateTime BirthDate { get; set; }
    }
}
