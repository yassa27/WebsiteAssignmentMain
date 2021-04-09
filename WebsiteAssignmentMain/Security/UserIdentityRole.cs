using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteAssignmentMain.Security
{
    public class UserIdentityRole : IdentityRole
    {
        public string IdentityRoleDescription { get; set; }
    }
}
