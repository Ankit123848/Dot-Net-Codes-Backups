using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_DBFIRST_DEMO.Models;
using System.Linq;

namespace MVC_DBFIRST_DEMO.Controllers
{
    public class ProductsController : Controller
    {

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }



        public readonly AppDbContext _context;
        public IActionResult Index()
        {
            var data = _context.Product.ToList();
            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Products product)
        {
            if (id != product.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(product);
        }


    }
}
