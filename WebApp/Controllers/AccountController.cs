using DAO.BaseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    [Route("")]
    public class AccountController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet("login")]
        [AllowAnonymous]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost("login")]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(AccountViewModel model)
        {
            Console.WriteLine("Login");
            Console.WriteLine("LoginModel.Email: " + model.LoginModel.Email +
                              "\n LoginModel.Password: " + model.LoginModel.Password +
                              "\n LoginModel.RememberMe: " + model.LoginModel.RememberMe);
            if (!ModelState.IsValid)
            {
                foreach (var state in ModelState)
                {
                    foreach (var error in state.Value.Errors)
                    {
                        Console.WriteLine($"Key: {state.Key}, Error: {error.ErrorMessage}");
                    }
                }
            }
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.LoginModel.Email, model.LoginModel.Password, 
                    model.LoginModel.RememberMe, lockoutOnFailure: false);
                Console.WriteLine("Result: " + result);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Invalid login attempt.");
            }

            return View(model);
        }

        [HttpGet("register")]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View("Login", new AccountViewModel());
        }

        [HttpPost("register")]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(AccountViewModel model)
        {
            Console.WriteLine("Register");
            Console.WriteLine("RegisterModel.Email: " + model.RegisterModel.Email +
                              "\n RegisterModel.Password: " + model.RegisterModel.Password +
                              "\n RegisterModel.ConfirmPassword: " + model.RegisterModel.ConfirmPassword);
            if (!ModelState.IsValid)
            {
                foreach (var state in ModelState)
                {
                    foreach (var error in state.Value.Errors)
                    {
                        Console.WriteLine($"Key: {state.Key}, Error: {error.ErrorMessage}");
                    }
                }
            }
            if (ModelState.IsValid)
            {
                var user = new User { UserName = model.RegisterModel.Email, Email = model.RegisterModel.Email };
                var result = await _userManager.CreateAsync(user, model.RegisterModel.Password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View("Login", model);
        }

        [HttpGet("logout")]
        // [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}