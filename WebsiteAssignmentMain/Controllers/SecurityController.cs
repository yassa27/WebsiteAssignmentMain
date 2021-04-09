using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebsiteAssignmentMain.Models;
using WebsiteAssignmentMain.Security;

namespace WebsiteAssignmentMain.Controllers
{
    public class SecurityController : Controller
    {

        private readonly UserManager<UserIdentity> userManager;
        private readonly RoleManager<UserIdentityRole> roleManager;
        private readonly SignInManager<UserIdentity> signinManager;

        public SecurityController(UserManager<UserIdentity> userManager, RoleManager<UserIdentityRole> roleManager,
            SignInManager<UserIdentity> signinManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.signinManager = signinManager;
        }
        public IActionResult RegisterPage()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RegisterPage(Register obj)
        {
            if (ModelState.IsValid)
            {
                if (!roleManager.RoleExistsAsync("Manager").Result)
                {
                    UserIdentityRole role = new UserIdentityRole();
                    role.Name = "Manager";
                    IdentityResult roleResult = roleManager.
                    CreateAsync(role).Result;
                }

                UserIdentity user = new UserIdentity();
                user.UserName = obj.UserName;
                user.Email = obj.Email;
                user.FullName = obj.FullName;
                user.BirthDate = obj.BirthDate;

                IdentityResult result = userManager.CreateAsync
                (user, obj.Password).Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Manager").Wait();
                    return RedirectToAction("SignIn", "Security");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid user details");
                }
            }
            return View(obj);
        }
        public IActionResult NoAccount()
        {
            return View();
        }
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SignIn(SignIn obj)
        {
            if (ModelState.IsValid)
            {
                var result = signinManager.PasswordSignInAsync
                (obj.UserName, obj.Password,
                    obj.RememberMe, false).Result;

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "MData");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid user details");
                }
            }
            return View(obj);
        }
        [HttpPost]

        [Authorize]
        [ValidateAntiForgeryToken]
        public IActionResult SignOutPage()
        {
            signinManager.SignOutAsync().Wait();
            return RedirectToAction("SignIn", "Security");
        }

    }
}
