using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace demoApp0818.Controllers
{
    public class IdentityUserController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public IdentityUserController(SignInManager<IdentityUser> signInManager,UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Models.Auth.Login login)
        {
            //if (ModelState.IsValid)
            //{
            //    var result = await _signInManager.PasswordSignInAsync(login.UserName, login.Password, false, false);
            //    if (result.Succeeded)
            //    {
            //        return RedirectToAction("Index", "Home");
            //    }
            //    ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            //}
            //return View(login);
            if (!ModelState.IsValid)
            {
                Console.WriteLine("Model state is not valid.");
                return View(login);
            }
            Console.WriteLine($"Attempting to log in user: {login.UserName}");
            return View(login);
        }
    }
}
