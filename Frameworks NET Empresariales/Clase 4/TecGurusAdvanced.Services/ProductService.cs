using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public void CreateProduct ( Product product)
        {
            //preparamos en memoria el / los productos a registrar
            dBContextAdvanced.Products.Add(product);
            //inserta en la BD
            dBContextAdvanced.SaveChanges();
        }
        public void CreateProducts ( List<Product> product)
        {
            //preparamos en memoria el / los productos a registrar
            foreach (var prod in product)
            {
                dBContextAdvanced.Products.Add(prod);
            }
            //inserta en la BD
            dBContextAdvanced.SaveChanges();
        }

        public void DeleteProduct (int Id)
        {
            var product = getProductById(Id);
            dBContextAdvanced.Products.Remove(product);
            dBContextAdvanced.SaveChanges();
        }

        public Product getProductById(int Id)
        {
            //Seleccionamos unicamente el primero 
            var product = dBContextAdvanced.Products.Where(w => w.ProductID == Id).FirstOrDefault();
            return product;
        }
        public void UpdateProduct ( Product product)
        {
            dBContextAdvanced.Entry(product).State = EntityState.Modified;
            dBContextAdvanced.SaveChanges();
        }
    }
}
