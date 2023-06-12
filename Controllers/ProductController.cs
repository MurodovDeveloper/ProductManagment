using Microsoft.AspNetCore.Mvc;
using MVCCRUD.DataAcces;
using MVCCRUD.Models;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace MVCCRUD.Controllers
{

    public class ProductController : Controller
    {
        private readonly AppDbContext _dbcontext;

        public ProductController(AppDbContext dbContext)
        {
            _dbcontext = dbContext;
        }
        public IActionResult Index()
        {
            var products = _dbcontext.Products.ToList();
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            _dbcontext.Products.Add(product);
            _dbcontext.SaveChanges();

            string message = "Successfully";

            ViewBag.Message = message;
            return RedirectToAction("Create");
        }
        //public IActionResult GetById()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult GetById(int? id)
        //{
        //    if (id == null)
        //    {
        //        return BadRequest(string.Empty);
        //    }

        //    Product product = _dbcontext.Products.Find(id);

        //    if (product == null)
        //    {
        //        return BadRequest();
        //    }

        //    return View("GetById", product);
        //}
       
        [HttpPost]
        public IActionResult Read()
        {
            var products = _dbcontext.Products.ToList();
            return View("Read", products);
        }
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(int Productid, Product model)
        {
            var product = _dbcontext.Products.FirstOrDefault(x => x.Id == Productid);

            if (product != null)
            {
                product.Price = model.Price;
                product.Name = model.Name;
                _dbcontext.SaveChanges();
            }

            return RedirectToAction("Read");
        }
        public IActionResult Delete()
        {
            return View("Delete");
        }
        [HttpPost]
        public IActionResult Delete(int Productid)
        {
            var product = _dbcontext.Products.Find(Productid);

            if (product != null)
            {
                _dbcontext.Products.Remove(product);
              //  _dbcontext.Products.Remove(product);
                _dbcontext.SaveChanges();
            }

            return RedirectToAction("Read");
        }
    }

}
