using Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _um;
        private readonly SignInManager<IdentityUser> _sm;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _um = userManager;
            _sm = signInManager;
        }

        [HttpGet]
        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registro(RegisterViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    UserName = viewModel.Email,
                    Email = viewModel.Email
                };

                var result = _um.CreateAsync(user, viewModel.Password);
                
                if(result.Result.Succeeded)
                {
                    await _sm.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Painel");
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
    }
}
