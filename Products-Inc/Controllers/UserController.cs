﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Products_Inc.Models;
using Products_Inc.Models.Interfaces;
using Products_Inc.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Products_Inc.Controllers
{
    [ApiController]
    [Route("api/[controller]")]



    public class UserController : Controller
    {
        //private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;
        //private RoleManager<IdentityRole> roleManager;
        //private UserManager<User> userManager;
        SignInManager<User> _signInManager;


        public UserController(IUserService userService, SignInManager<User> signInManager) // , RoleManager<IdentityRole> roleMgr, UserManager<User> userMrg) // removed logging /ER  ILogger<UserController> logger,
        {
            //_logger = logger;
            _userService = userService;
            _signInManager = signInManager;
            //roleManager = roleMgr;
            //userManager = userMrg;
        }


        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                if (await _userService.Login(loginModel))
                {
                    return new OkObjectResult(new { msg = "Logged in" });
                }
                else
                {
                    return new BadRequestObjectResult(new { errorMsg = "Incorrect password/username" });
                }
            }
            else
            {
                Console.WriteLine("Incorrect model");
                return new BadRequestObjectResult(new { errorMsg = "Incorrect model" });
            }
        }



        [HttpPost("register")]
        public async Task<ActionResult> Register([FromBody] RegisterModel registerModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    UserViewModel userModel = await _userService.Add(registerModel);
                    return new CreatedResult("/user/register", userModel);

                }
                catch (Exception e)
                {
                    return new BadRequestObjectResult(new { errorMsg = e.Message });
                }
            }
            else
            {
                return new BadRequestObjectResult(new { errorMsg = "Incorrect model" });
            }
        }



        [HttpPost("logout")]
        public async Task<IActionResult> Logout(string returnUrl = null)
        {
            await _signInManager.SignOutAsync();

            if (returnUrl != null)
            {
                return new OkObjectResult(new { msg = "Logged Out. Can redirect to page is needed" });
            }
            else
            {
                return new OkObjectResult(new { msg = "Logged Out" });
            }
        }



        [HttpPut("edituser/{userId}")]
        public async Task<IActionResult> EditUser(string userId, [FromBody] RegisterModel updateModel)
        {
            UserViewModel user = await _userService.Update(userId, updateModel);


            return new OkObjectResult(user);
        }

        [Authorize(Roles = "User")]
        [HttpGet("me")]
        public async Task<IActionResult> GetLoggedInUserInfo()
        {
            if (User.Identity.IsAuthenticated)
            {
                UserViewModel user = await _userService.FindBy(User.Identity.Name);
                return new OkObjectResult(user);
            }
            else
            {
                return new UnauthorizedResult();
            }
        }




        public async Task<IActionResult> GetUserById(int id)
        {
            Task<UserViewModel> user = _userService.FindById(id);

            if (user.Result.FoundUser)
            {
                return new OkObjectResult(user.Result);
            }
            else
            {
                return new BadRequestObjectResult(new { errorMsg = "UserId not found." });
            }
        }


        [HttpGet("accessdenied")]
        public IActionResult AccessDenied()
        {
            return new BadRequestObjectResult(new { errorMsg = "Access Denied." });
        }


        [HttpGet("testapi")]
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult testapi()
        {
            //List<UserViewModel> user = _userService.All();
            var hejsan = "bööööös";

            return Json(hejsan);
        }

        public IActionResult IsUserLoggedIn()
        {
            //List<UserViewModel> user = _userService.All();
            var hejsan = "bööööös";

            return Json(hejsan);
        }

        //private void Errors(IdentityResult result)
        //{
        //    foreach (IdentityError error in result.Errors)
        //        ModelState.AddModelError("", error.Description);
        //}


        //public IActionResult Create() => View("CreateRole");


        //[HttpPost]
        //public async Task<IActionResult> Create([Required] string name)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        IdentityResult result = await roleManager.CreateAsync(new IdentityRole(name));
        //        if (result.Succeeded)
        //            return RedirectToAction("Index");
        //        else
        //            Errors(result);
        //    }
        //    return View(name);
        //}


        //[HttpPost]
        //public async Task<IActionResult> Delete(string id)
        //{
        //    IdentityRole role = await roleManager.FindByIdAsync(id);
        //    if (role != null)
        //    {
        //        IdentityResult result = await roleManager.DeleteAsync(role);
        //        if (result.Succeeded)
        //            return RedirectToAction("Index");
        //        else
        //            Errors(result);
        //    }
        //    else
        //        ModelState.AddModelError("", "No role found");
        //    return View("Index", roleManager.Roles);
        //}


        //public async Task<IActionResult> Update(string id)
        //{
        //    IdentityRole role = await roleManager.FindByIdAsync(id);
        //    List<User> members = new List<User>();
        //    List<User> nonMembers = new List<User>();
        //    foreach (User user in userManager.Users)
        //    {
        //        var list = await userManager.IsInRoleAsync(user, role.Name) ? members : nonMembers;
        //        list.Add(user);
        //    }
        //    return View("UpdateRole", new IdentityRoleEdit
        //    {
        //        Role = role,
        //        Members = members,
        //        NonMembers = nonMembers
        //    });
        //}


        //[HttpPost]
        //public async Task<IActionResult> Update(IdentityRoleModification model)
        //{
        //    IdentityResult result;
        //    if (ModelState.IsValid)
        //    {
        //        foreach (string userId in model.AddIds ?? new string[] { })
        //        {
        //            User user = await userManager.FindByIdAsync(userId);
        //            if (user != null)
        //            {
        //                result = await userManager.AddToRoleAsync(user, model.RoleName);
        //                if (!result.Succeeded)
        //                    Errors(result);
        //            }
        //        }
        //        foreach (string userId in model.DeleteIds ?? new string[] { })
        //        {
        //            User user = await userManager.FindByIdAsync(userId);
        //            if (user != null)
        //            {
        //                result = await userManager.RemoveFromRoleAsync(user, model.RoleName);
        //                if (!result.Succeeded)
        //                    Errors(result);
        //            }
        //        }
        //    }

        //    if (ModelState.IsValid)
        //        return RedirectToAction(nameof(Index));
        //    else
        //        return await Update(model.RoleId);
        //}


    }
}