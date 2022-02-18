using Lawyer.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http.Headers;
using System.Linq;
using System.Net.Http;
using System.Collections.Generic;
using Lawyer.Service.UserService;
using Lawyer.Models.Account;

namespace Lawyer.Controllers
{
    public class HomeController : Controller
    {

        private IUserService _userService;
        public HomeController(IUserService userService)
        {
            _userService = userService;
        }


        public IActionResult Index()
        {
            ViewData["Title"] = "موسسه حقوقی صلح حافظ";
            List<User> users = _userService.GetAllUsersForGrid().ToList();
            return View(users);

        }

        [HttpGet("درباره-موسسه-حقوقی-صلح-حافظ")]
        public IActionResult AboutUs()
        {
              return View();

        }      
        [HttpGet("ارتباط-با-موسسه-حقوقی-صلح-حافظ")]
        public IActionResult ContactUs()
        {
              return View();

        }
    }

}
