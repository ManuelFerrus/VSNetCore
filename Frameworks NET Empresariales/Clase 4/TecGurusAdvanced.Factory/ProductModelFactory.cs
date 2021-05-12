using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecGurusAdvanced.Entities;
using TecGurusAdvanced.Model;
using TecGurusAdvanced.Services;

namespace TecGurusAdvanced.Factory
{
    public class ProductModelFactory
    {

        ProductService productService = new ProductService();
        CategoryService categoryService = new CategoryService();
        private const int PageSize = 10;

        public ProductViewModel PrepareToProductModel()
        {

            ProductViewModel productView = new ProductViewModel();
            var query = ProductsWithCategory();
            productView.TotalData = query.Count();
            productView.NumberOfPage = Convert.ToInt32(Math.Ceiling((double)query.Count() / PageSize));
            productView.CurrentPage = 1;
            productView.Data = query.Take(PageSize).ToList();
            return productView;
        }

        public ProductViewModel PrepareToProductModel(string productNameSearch, int page)
        {
            ProductViewModel productView = new ProductViewModel();
            var query = ProductsWithCategory();
            if (!string.IsNullOrEmpty(productNameSearch))
            {
                query = query.Where(w => w.ProductName.ToUpper().Contains(productNameSearch.ToUpper()) ||
                w.CategoryName.ToUpper().Contains(productNameSearch.ToUpper()));
            }

            productView.NumberOfPage = Convert.ToInt32(Math.Ceiling((double)query.Count() / PageSize));
            productView.TotalData = query.Count();
            productView.CurrentPage = page;
            query = query.Skip(PageSize * (page - 1)).Take(PageSize);
            productView.Data = query.ToList();
            return productView;
        }

        public IQueryable<ProductModel> ProductsWithCategory()
        {
            var productModel = (from p in productService.GetProducts().ToList()
                                join c in categoryService.GetCategories().ToList()
                                on p.CategoryID equals c.CategoryID
                                select new ProductModel
                                {
                                    ProductID = p.ProductID,
                                    ProductName = p.ProductName,
                                    UnitPrice = p.UnitPrice,
                                    CategoryID = c.CategoryID,
                                    CategoryName = c.CategoryName
                                }
                                ).AsQueryable();

            return productModel;
        }

        public Product PrepareToProduct(ProductModel productModel)
        {
            //se convierte productModel a Product
            return Mapper.Map<Product>(productModel);
            //tenemos que crear el servicio en ProductService
        }
        public ProductModel PrepareToProductModelById(int productId)
        {
            var product = productService.getProductById(productId);
            //se convierte productModel a Product
            return Mapper.Map<ProductModel>(product);
            //tenemos que crear el servicio en ProductService
        }

    }
}
