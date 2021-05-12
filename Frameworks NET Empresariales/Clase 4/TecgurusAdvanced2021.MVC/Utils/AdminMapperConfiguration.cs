using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TecGurusAdvanced.Entities;
using TecGurusAdvanced.Model;

namespace TecgurusAdvanced2021.MVC.Utils
{
    public class AdminMapperConfiguration
    {
        //ANTES DE ESTE PASO SE INSTALA EL NUGGET DE AUTOMAPPER
        public static void RegisterMaps()
        {
            Mapper.Initialize(config =>
            {
                //Entities a model
                config.CreateMap<Product, ProductModel>();
                config.CreateMap<Category, CategoryModel>();

                //Model a Entities
                config.CreateMap<ProductModel, Product>();
                config.CreateMap<Category, CategoryModel>();

                //una vez hecho el mapeo se tiene que ir a registrar en Global.asax.cs
            }
            );
        }
    }
}