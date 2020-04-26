using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dal;
using Model;
namespace Day6.Controllers
{
    public class LoginController : Controller
    {
        Udal dal = new Udal();
        public IActionResult Login(Umodel m)
        {
            return View(dal.DL(m));
        }
    }
}