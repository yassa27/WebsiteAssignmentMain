﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteAssignmentMain.Models
{
    public class SignIn
    {
        [Required(ErrorMessage = " ")]
        public string UserName { get; set; }
        [Required(ErrorMessage = " ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
