﻿using Microsoft.AspNetCore.Mvc;

namespace EFCoreWithAsp.netCore.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(string name)
        {
            return View();
        }
    }
}
