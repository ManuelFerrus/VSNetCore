namespace TecgurusAdvanced2021.MVC_Prueba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeacher : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 25),
                        Edad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TeacherId);
            
            AddColumn("dbo.Students", "Promedio", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Promedio");
            DropTable("dbo.Teachers");
        }
    }
}
