﻿using Microsoft.AspNetCore.Mvc;

namespace PracticaMVC.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
