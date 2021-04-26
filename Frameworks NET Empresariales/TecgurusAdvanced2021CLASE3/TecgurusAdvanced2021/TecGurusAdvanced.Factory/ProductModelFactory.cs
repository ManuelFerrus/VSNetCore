using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            //int iNumPage = productView.TotalData / 10;
            //int iResiduo = productView.TotalData % 10;
            //if (iResiduo > 0)
            //{
            //    iNumPage++;
            //}
            //productView.NumbreOfPage = iNumPage;
            //siempre redondea hacia arriba
            productView.NumbreOfPage = Convert.ToInt32(Math.Ceiling((double)query.Count() / PageSize));
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
                query = query.Where(w => w.ProductName.ToUpper().Contains(productNameSearch.ToUpper())
                                        || w.CategoryName.ToUpper().Contains(productNameSearch.ToUpper()));
                //if (query.Count() == 0)
                //{
                //    query = query.Where(w => w.CategoryName.ToUpper().Contains(productNameSearch.ToUpper()));
                //}
            }
            productView.NumbreOfPage = Convert.ToInt32(Math.Ceiling((double)query.Count() / PageSize));
            productView.TotalData = query.Count();
            productView.CurrentPage = page;
            //Se haca para ir tomando los 10, de la pagina actual -1 uno
            //si estoy en la pagina 3, necesito ver de la 20 a la 30
            query = query.Skip(PageSize * (page - 1)).Take(PageSize);

            productView.Data = query.ToList();
            return productView;
        }

        //Se cambia para que todavia no vaya a la BD
        //public List<ProductModel> ProductsWithCategory()
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
    }
}
