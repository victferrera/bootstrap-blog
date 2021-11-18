using Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BlogApp.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _um;
        private readonly SignInManager<IdentityUser> _sm;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _um = userManager;
            _sm = signInManager;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Registro()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registro(RegisterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    UserName = viewModel.Email,
                    Email = viewModel.Email
                };

                var result = _um.CreateAsync(user, viewModel.Password);

                if (result.Result.Succeeded)
                {
                    await _sm.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Painel");
                }
            }

            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _sm.PasswordSignInAsync(viewModel.Email, viewModel.Password, false, false);

                if(result.Succeeded)
                    return RedirectToAction("Index", "Painel");
            }

            return View();
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Logout(LoginViewModel viewModel)
        {
            await _sm.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }
    }
}
