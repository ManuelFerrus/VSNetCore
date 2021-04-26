namespace TecgurusAdvanced2021.MVC.DatabaseFirstExample
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBContextDatabaseFirst : DbContext
    {
        //Nombre de la cade de conexion con la cual voy a trabajar en el contexto
        public DBContextDatabaseFirst()
            : base("name=ConnectionDataBaseFirst")
        {
        }

        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Seller> Sellers { get; set; }
        public virtual DbSet<SellersXBrand> SellersXBrands { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>()
                .HasMany(e => e.SellersXBrands)
                .WithOptional(e => e.Brand)
                .HasForeignKey(e => e.IDBrand);

            modelBuilder.Entity<Seller>()
                .HasMany(e => e.SellersXBrands)
                .WithRequired(e => e.Seller)
                .HasForeignKey(e => e.IDSeller)
                .WillCascadeOnDelete(false);
        }
    }
}
