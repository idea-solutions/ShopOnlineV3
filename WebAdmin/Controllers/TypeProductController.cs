using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAdmin.Common;
using WebAdmin.Models.Business;
using WebAdmin.Models.ModelView;

namespace WebAdmin.Controllers
{
    public class TypeProductController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult ForProduct(Guid productId)
        {
            ViewBag.Product = TypeProductBus.GetByProductIdAsync(productId).Result;
            return View();
        }

        [HttpPost]
        public IActionResult AddTypeProduct(TypeProductMv typeProduct)
        {

            var res = TypeProductBus.CreateNewTypeProductBusAsync(typeProduct).Result;
            if (res) TempData[ConstKey.Success] = "Success";
            else TempData[ConstKey.Error] = "Fail, Try again!";
            return RedirectToAction("ForProduct", "TypeProduct", new { productId = typeProduct.ProductId });

        }
    }
}
