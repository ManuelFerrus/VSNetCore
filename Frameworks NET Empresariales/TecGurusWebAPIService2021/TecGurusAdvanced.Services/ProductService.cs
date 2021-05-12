using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecGurusAdvanced.Entities;
//using System.Data.Entity;

namespace TecGurusAdvanced.Services
{
    public class ProductService
    {
        //consultar todos los productos, ordernados por nombre y que su categoria no sea beverages
        DBContextWebAPI dBContext = new DBContextWebAPI();

        public List<Product> GetProducts()
        {
            //var query = dBContextWebAPI.Products.Where(w => w.CategoryID != 1).ToList();
            var query = (from p in dBContext.Products.ToList()
                         join c in dBContext.Categories.ToList()
                         on p.CategoryID equals c.CategoryID
                         where c.CategoryID != 1
                         orderby p.ProductName
                         select p
                         ).ToList();

            return query;
        }
    }
}
