using DataAccess;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Web.Areas.ProductAdmin.Controllers
{
    [Area("ProductAdmin")]
    public class ProductController : Controller
    {
        private readonly ProductManager _productManager;
        private readonly CategoryManager _categoryManager;

        public ProductController(ProductManager productManager, CategoryManager categoryManager)
        {
            _productManager = productManager;
            _categoryManager = categoryManager;
        }



        // GET: ProductController
        public ActionResult Index()
        {
            return View(_productManager.GetAll());
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int? id)
        {
            if(id == null) return NotFound();
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = _categoryManager.GetAll();
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            ViewBag.CategoryId = _categoryManager.GetAll();
            if (ModelState.IsValid)
            {

                _productManager.Add(product);
                return RedirectToAction(nameof(Index));
            }

            return View();
        }


        // GET: ProductController/Edit/5
        public ActionResult Edit(int? id)
        {
            if(id==null) return NotFound();
            return View();
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int? id)
        {
            if(id==null) return NotFound();
            return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
