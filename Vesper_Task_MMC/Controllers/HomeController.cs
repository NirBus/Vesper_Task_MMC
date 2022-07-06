using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Vesper_Task_MMC.DAL;
using Vesper_Task_MMC.Models;

namespace Vesper_Task_MMC.Controllers
{
    public class HomeController:Controller
    {
        private readonly AppDbContext context;

        public HomeController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {

            List<Cart> carts = context.Carts.ToList();
          return View(carts); 
        }
       public ActionResult CartDetail(int? id)
        {
            Cart cart = context.Carts.FirstOrDefault(c => c.Id == id);
            return View(cart);
        }
    }
}
