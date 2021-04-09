using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebsiteAssignmentMain.Security
{
    public class UserIdentityContext : IdentityDbContext<UserIdentity, UserIdentityRole, string>
    {
        public UserIdentityContext
        (DbContextOptions<UserIdentityContext> options)
        : base(options)
        {
        }
    }
}
