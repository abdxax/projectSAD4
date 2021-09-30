using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Project4SAD.ViewModel;

namespace Project4SAD.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        public AccountController(UserManager<IdentityUser> user,SignInManager<IdentityUser>sign)
        {
            userManager = user;
            signInManager = sign;
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(ViewModelRegister reg)
        {
            if (ModelState.IsValid)
            {
                var user_ide = new IdentityUser()
                {
                    Email=reg.Email,
                    UserName=reg.Email
                };
                var result = await userManager.CreateAsync(user_ide, reg.pass);
                if (result.Succeeded)
                {
                    var sin = await signInManager.PasswordSignInAsync(user_ide.UserName, reg.pass,false,false); ;
                    // return Content("the user id is " + user_ide.Id);
                    if (sin.Succeeded)
                    {
                        return Redirect("auths");
                    }
                }
            }
            return Content("the user id is " +"error");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(ViewModelLogin login)
        {
            var a = new IdentityUser()
            {
                Email = login.Email,
                UserName = login.Email
            };
            var result = await signInManager.PasswordSignInAsync(login.Email,login.Password,false,false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return Redirect("Login");
            }
        }

        [Authorize]
        public  IActionResult auths()
        {
            return Content("Work auth");
        }
    }
}
