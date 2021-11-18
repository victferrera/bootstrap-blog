using Auth;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Services
{
    public class UserService
    {
        private readonly UserManager<IdentityUser> _um;
        private readonly SignInManager<IdentityUser> _sm;

        public UserService(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _um = userManager;
            _sm = signInManager;
        }

        public async Task<bool> RegistroAsync(RegisterViewModel viewModel)
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
                return true;
            }
            return false;
        }

        public async Task<bool> LoginAsync(LoginViewModel viewModel)
        {
            var result = await _sm.PasswordSignInAsync(viewModel.Email, viewModel.Password, false, false);

            if (result.Succeeded)
                return true;
            else
                return false;
        }

        public async Task LogoutAsync()
        {
            await _sm.SignOutAsync();
        }
    }


}

