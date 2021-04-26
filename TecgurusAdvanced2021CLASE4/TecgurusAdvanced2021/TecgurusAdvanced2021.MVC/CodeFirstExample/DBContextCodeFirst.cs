using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TecgurusAdvanced2021.MVC.CodeFirstExample
{
    public class DBContextCodeFirst : DbContext
    {
        public DBContextCodeFirst() : base("name=ConnectionCodeFirst")
        {
        }


        public virtual DbSet<Stundents> Student { get; set; }
    }
}