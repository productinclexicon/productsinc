﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Products_Inc.Models;
using Products_Inc.Models.Interfaces;
using Products_Inc.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Products_Inc.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(IUserService userService, ILogger<UserController> logger)
        {
            _logger = logger;
            this._userService = userService;
        }

        [HttpPost]
        public async Task<ActionResult> Login([FromBody] LoginModel loginModel)
        {  
            if (ModelState.IsValid)
            {
                try
                {
                    if(await _userService.Login(loginModel)) {

                        return new OkResult();
                    }
                    else
                    {
                        return new BadRequestObjectResult(new { errorMsg = "Incorrect password/username" });
                    }
                }
                catch(Exception)
                {
                    return new BadRequestObjectResult(new { errorMsg = "User cannot be found" });

                }

            }
            else
            {
                return new BadRequestObjectResult(new { errorMsg = "Incorrect model" });
            }
        }

        [HttpPost("[controller]/register")]
        public async Task<ActionResult> Register([FromBody] RegisterModel registerModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    UserViewModel userModel = await _userService.Add(registerModel);
                    return new CreatedResult("/user/register", userModel);

                }catch(Exception e)
                {
                    return new BadRequestObjectResult(new { errorMsg =  e.Message });
                }
            }
            else
            {
                return new BadRequestObjectResult(new { errorMsg = "Incorrect model" });
            }
        }

        [HttpPost("[controller]/logout")]
        public ActionResult Logout()
        {
            _userService.Logout();
            return new OkResult();
        }

        //[HttpGet("[controller]/orders")]
        //public IActionResult GetUserOrders()
        //{
        //    string loggedInUserName = this.User.Identity.Name;
        //    //List<OrderModel> orders = _orderService.GetOrdersBy(loggedInUserName);
        //    return new OkObjectResult(new { });
        //}

        [HttpGet("[controller]/orders")]
        public IActionResult Orders()
        {
            return PartialView("Orders");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        /*[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ProductsViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}


/*
 
 
  [HttpPOST]
C - Create new user 
return view with the created product


R -  GET user info


U - get 1 user to view and edit. 
When pressing save /submit button goto PUT/PAtch.

 
U - PUT/Patch
Edit user find by ID
return partial view, viewmodel 



D - 






 
 
 
 
 
 
 
 
 
 
 */