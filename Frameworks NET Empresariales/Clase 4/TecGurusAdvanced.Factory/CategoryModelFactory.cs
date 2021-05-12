using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecGurusAdvanced.Model;
using TecGurusAdvanced.Services;

namespace TecGurusAdvanced.Factory
{
    public class CategoryModelFactory
    {
        CategoryService categoryService = new CategoryService();

        public List<CategoryModel> PrepareListCategoriesToListCategoyModel()
        {
            //Se agrega en el admin mapper, para la conversion
            return Mapper.Map < List<CategoryModel> >(categoryService.GetCategories().ToList());
        }
    }
}
