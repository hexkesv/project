using final.Data;
using final.Models;
using Microsoft.AspNetCore.Mvc;

namespace final.Controllers
{
    public class MenuController : Controller
    {
        private readonly ProductContext _context;

        public MenuController(ProductContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.OrderBy(p => p.Name).ToList();
            return View(products);   // FIXED
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product, IFormFile imageFile)
        {
            if (imageFile != null && imageFile.Length > 0)
            {
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/products");
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                var fileName = Path.GetFileName(imageFile.FileName);
                var filePath = Path.Combine(folder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await imageFile.CopyToAsync(stream);
                }

                product.ImagePath = "/images/products/" + fileName;
            }

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
                return NotFound();

            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Product product, IFormFile imageFile)
        {
            var existingProduct = _context.Products.Find(id);
            if (existingProduct == null)
                return NotFound();

            existingProduct.Name = product.Name;
            existingProduct.Category = product.Category;
            existingProduct.Price = product.Price;

            if (imageFile != null && imageFile.Length > 0)
            {
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/products");
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                var fileName = Path.GetFileName(imageFile.FileName);
                var filePath = Path.Combine(folder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await imageFile.CopyToAsync(stream);
                }

                existingProduct.ImagePath = "/images/products/" + fileName;
            }

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
