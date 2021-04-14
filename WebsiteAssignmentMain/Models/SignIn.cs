using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteAssignmentMain.Models
{
    public class SignIn
    {
        [Required(ErrorMessage = "Invalid Username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Invalid Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
