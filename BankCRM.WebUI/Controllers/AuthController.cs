using BankCRM.Dto.AuthDtos;
using BankCRM.Entity.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BankCRM.WebUI.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AuthController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
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
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            if (!ModelState.IsValid)
            {
                return View(loginDto);
            }

            AppUser? user;

            if (loginDto.UserNameOrEmail.Contains("@"))
            {
                user = await _userManager.FindByEmailAsync(
                    loginDto.UserNameOrEmail);
            }
            else
            {
                user = await _userManager.FindByNameAsync(
                    loginDto.UserNameOrEmail);
            }

            if (user is null)
            {
                ModelState.AddModelError(
                    string.Empty,
                    "Kullanıcı adı, e-posta veya şifre hatalı.");

                return View(loginDto);
            }

            if (!user.IsActive)
            {
                ModelState.AddModelError(
                    string.Empty,
                    "Kullanıcı hesabınız aktif değildir.");

                return View(loginDto);
            }

            var result = await _signInManager.PasswordSignInAsync(
                user,
                loginDto.Password,
                loginDto.RememberMe,
                lockoutOnFailure: true);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Dashboard");
            }

            if (result.IsLockedOut)
            {
                ModelState.AddModelError(
                    string.Empty,
                    "Çok fazla hatalı giriş yaptınız. Hesabınız 15 dakika süreyle kilitlendi.");

                return View(loginDto);
            }

            ModelState.AddModelError(
                string.Empty,
                "Kullanıcı adı, e-posta veya şifre hatalı.");

            return View(loginDto);
        }

        [Authorize]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login","Auth");
        }

    }
}
