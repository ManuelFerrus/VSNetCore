using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TecGurusAdvanced.Entities;
using TecGurusAdvanced.Factory;
using TecGurusAdvanced.Model;
using TecGurusAdvanced.Services;

namespace TecgurusAdvanced2021.MVC.Controllers
{
    public class ProductController : Controller
    {
        ProductModelFactory productModelFactory = new ProductModelFactory();
        ProductService productService = new ProductService();
        CategoryModelFactory categoryModelFactory = new CategoryModelFactory();
        // GET: Product
        public ActionResult Index()
        {
            var products = productModelFactory.PrepareToProductModel();
            return View(products);
        }

        public ActionResult Create()
        {
            SetDDLCategories();      
            return View();
        }

        private void SetDDLCategories()
        {
            var listCategoryModel = categoryModelFactory.PrepareListCategoriesToListCategoyModel();
            //retornamos el listado en forma de viewbag
            //se cacha directamente en la vista del create, con el nombre de nuestro viewbag
            ViewBag.Categories = new SelectList(listCategoryModel, "CategoryID", "CategoryName");
        }

        [HttpPost]
        public ActionResult Create(ProductModel productModel)
        {
            //Una vez puesto el listado no es necesario el forazo de la info
            //productModel.CategoryID = 1;
            //se validan todos los campo
            if (ModelState.IsValid)
            {
                //Convierte  ProductModel a Product
                var product = productModelFactory.PrepareToProduct(productModel);

                //Inserta un Producto
                productService.CreateProduct(product);
                //Se redirige a la vista para que se carge la ventana
                return RedirectToAction("Index");
            }
            SetDDLCategories();
            return View("Create");
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

        [HttpPost]
        public ActionResult ajax_Delete(int ProductId)
        {

            try
            {
                productService.DeleteProduct(ProductId);
                var model = productModelFactory.PrepareToProductModel();
                return PartialView("_ProductModelList", model);
            }
            catch (Exception ex)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return null;
            }
        }

        public ActionResult Edit ( int productId)
        {
            var product = productModelFactory.PrepareToProductModelById(productId);
            SetDDLCategories();
            return View("Edit", product);
        }
        
        [HttpPost]
        public ActionResult Edit (ProductModel product)
        {
            if (ModelState.IsValid)
            {
                //Convierte  ProductModel a Product
                var editProduct = productModelFactory.PrepareToProduct(product);

                //Inserta un Producto
                productService.UpdateProduct(editProduct);
                //Se redirige a la vista para que se carge la ventana
                return RedirectToAction("Index");
            }
            SetDDLCategories();
            //return View("Edit");
            return View("Index");
        }

        //CRUD PARA CATEGORIAS
    }
}