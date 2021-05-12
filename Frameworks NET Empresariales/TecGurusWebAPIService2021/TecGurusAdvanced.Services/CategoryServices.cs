using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecGurusAdvanced.Entities;

namespace TecGurusAdvanced.Services
{
    public class CategoryServices
    {
        //consultar todos los productos, ordernados por nombre y que su categoria no sea beverages
        DBContextWebAPI dBContext = new DBContextWebAPI();

        public List<Category> GetCategories()
        {
            //var query = dBContextWebAPI.Products.Where(w => w.CategoryID != 1).ToList();
            var categories = dBContext.Categories.OrderBy(o => o.CategoryName).ToList();
            return categories;
        }
    }
}
