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
            //var products = productModelFactory.ProductsWithCategory();
            //return View(products);
            //Recuperacion de la informacion, se regresa en una vista normal
            //DBContextAdvanced dBContextAdvanced = new DBContextAdvanced();
            //var productos = dBContextAdvanced.Products.ToList();
            //return View(productos);

            //var productos = productModelFactory.ProductsWithCategory();
            var productos = productModelFactory.PrepareToProductModel();
            return View(productos);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ProductModel productModel)
        {

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