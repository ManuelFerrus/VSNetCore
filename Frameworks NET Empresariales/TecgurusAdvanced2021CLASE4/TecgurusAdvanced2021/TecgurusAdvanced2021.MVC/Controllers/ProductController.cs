using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TecGurusAdvanced.Entities;
using TecGurusAdvanced.Factory;
using TecGurusAdvanced.Model;

namespace TecgurusAdvanced2021.MVC.Controllers
{
    public class ProductController : Controller
    {
        ProductModelFactory productModelFactory = new ProductModelFactory();
        // GET: Product
        public ActionResult Index()
        {
            var products = productModelFactory.PrepareToProductModel();
            return View(products);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ProductModel productModel)
        {

            if (ModelState.IsValid)
            {
                //Convierte  ProductModel a Product
                //var product = productModelFactory.PrepareToProduct();
                //Inserta un Producto
                //productService.CreateProduct(productModel);
                //return View("Index");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Ajax_Search(ProductViewModel productView)
        {
            var model = productModelFactory.PrepareToProductModel(productView.ProductNameSearch, 1);
            return PartialView("_ProductModelList", model);
        }

        [HttpPost]
        public ActionResult ajax_ChangePage(int page, string productNameSearch)
        {

            var model = productModelFactory.PrepareToProductModel(productNameSearch, page);
            return PartialView("_ProductModelList", model);
        }

    }
}