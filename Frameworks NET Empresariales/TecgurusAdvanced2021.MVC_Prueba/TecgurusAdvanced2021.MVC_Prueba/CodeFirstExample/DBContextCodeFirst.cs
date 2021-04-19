using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TecgurusAdvanced2021.MVC_Prueba.CodeFirstExample
{
    public class DBContextCodeFirst : DbContext
    {
        public DBContextCodeFirst()
            : base("name = ConnectionCodeFirst")
        { 
        }
        
        public virtual DbSet<Students> Student { get; set; }
        public virtual DbSet<Teachers> Teacher { get; set; }
    }
}