using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using InteriorShoppe.Models;
using InteriorShoppe.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;

namespace InteriorShoppe.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private IEmailSender _email;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IEmailSender email)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _email = email;
        }

        /// <summary>
        /// Takes user Registration page
        /// </summary>
        /// <returns>Registration View</returns>
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        /// <summary>
        /// Posts user Registration data to interiorShoppeIdentityDb
        /// </summary>
        /// <param name="rvm">Register ViewModel</param>
        /// <returns>Home View</returns>
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel rvm)
        {
            if (ModelState.IsValid)
            {
                // start the registration process
                ApplicationUser user = new ApplicationUser()
                {
                    UserName = rvm.Email,
                    Email = rvm.Email,
                    FirstName = rvm.FirstName,
                    LastName = rvm.LastName,
                    Birthday = rvm.Birthday
                };

                var result = await _userManager.CreateAsync(user, rvm.Password);

                if (result.Succeeded)
                {
                    // Custom Claim type for full name
                    Claim fullNameClaim = new Claim("FullName", $"{user.FirstName} {user.LastName}");

                    // claim type for birthday
                    Claim birthdayClaim = new Claim(
                        ClaimTypes.DateOfBirth,
                        new DateTime(user.Birthday.Year, user.Birthday.Month, user.Birthday.Day).ToString("u"), ClaimValueTypes.DateTime);

                    // claim type for email
                    Claim emailClaim = new Claim(ClaimTypes.Email, user.Email, ClaimValueTypes.Email);

                    if (user.Email.Contains("admin@thewrightstuff.com"))
                    {
                        Claim adminClaim = new Claim(ClaimTypes.Role, "Admin");
                        await _userManager.AddClaimAsync(user, adminClaim);
                    }

                    List<Claim> myclaims = new List<Claim>()
                    {
                        fullNameClaim,
                        birthdayClaim,
                        emailClaim
                    };

                    //myclaims.Add(fullNameClaim);
                    //myclaims.Add(birthdayClaim);
                    //myclaims.Add(emailClaim);

                    await _userManager.AddClaimsAsync(user, myclaims);

                    await _signInManager.SignInAsync(user, isPersistent: false);

                    await _email.SendEmailAsync(rvm.Email, "Welcome!", "<p> Hello!!! <strong>Thank you for registering with the Wright Stuff!! </strong> </p>");

                    return RedirectToAction("Index", "Home");

                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }

            }
            return View(rvm);
        }

        /// <summary>
        /// Takes user Login page
        /// </summary>
        /// <returns>Login View</returns>
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// Verifies user login credentials
        /// </summary>
        /// <param name="rvm">Login ViewModel</param>
        /// <returns>Home View</returns>
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel lvm)
        {
           
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(lvm.Email, lvm.Password, false, false);

                if (result.Succeeded)
                {
                    var userManager = _signInManager.UserManager;
                    var user = await userManager.FindByEmailAsync(lvm.Email);
                    var claims = await userManager.GetClaimsAsync(user);
                    var role = claims.Where(c => c.Type == ClaimTypes.Role).ToList();

                    if (role.Where(r => r.Value == "Admin").Count() > 0)
                    {
                        return RedirectToAction("Index", "Admin");
                    }

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Wrong username or passsword");
                }
            }

            return View(lvm);
        }

        /// <summary>
        /// Logs user out of the web app
        /// </summary>
        /// <param name="rvm">Register ViewModel</param>
        /// <returns>Home View</returns>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

    }
}

