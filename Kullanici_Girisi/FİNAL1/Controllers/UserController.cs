using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FİNAL1.Controllers
{
    public class UserController : Controller
    {
        //View geri döndürüldü Index.cshtml get edildi
        public IActionResult Index()
        {
            return View();
        }
    }
}
