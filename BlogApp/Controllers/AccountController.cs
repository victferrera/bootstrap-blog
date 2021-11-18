using Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Services;
using System.Threading.Tasks;

namespace BlogApp.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        public UserService _service;
        public AccountController(UserService service)
        {
            _service = service;
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
                var retorno = await _service.RegistroAsync(viewModel);

                if (retorno == true)
                    return RedirectToAction("Index", "Painel");
                else
                    return View();
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
                var retorno = await _service.LoginAsync(viewModel);
                if(retorno == true)
                {
                    return RedirectToAction("Index","Painel");
                }
                else
                {
                    return View();
                }
            }

            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Logout(LoginViewModel viewModel)
        {
            await _service.LogoutAsync();
            return RedirectToAction(nameof(Login));
        }
    }
}
