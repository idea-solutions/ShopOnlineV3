using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAdmin.Controllers
{
    public class TypeProductController : Controller
    {
        public IActionResult Index(Guid productId)
        {
            return View();
        }
    }
}
