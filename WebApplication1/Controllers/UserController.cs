﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult RegisterView()
        {
            return View();
        }
    }
}
