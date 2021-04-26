using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecGurusAdvanced.Entities;

namespace TecGurusAdvanced.Services
{
    public class ProductService
    {
        DBContextAdvanced dBContextAdvanced = new DBContextAdvanced();
        public IQueryable<Product> GetProducts()
        {
            return dBContextAdvanced.Products;
        }




    }
}
