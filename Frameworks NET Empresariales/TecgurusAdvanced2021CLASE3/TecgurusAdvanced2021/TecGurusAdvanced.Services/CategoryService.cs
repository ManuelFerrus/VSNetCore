using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecGurusAdvanced.Entities;

namespace TecGurusAdvanced.Services
{
    public class CategoryService
    {
        DBContextAdvanced dBContextAdvanced = new DBContextAdvanced();
        public IQueryable<Category> GetCategories()
        {
            return dBContextAdvanced.Categories;
        }
    }
}
