namespace TecgurusAdvanced2021.MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stundents",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Age = c.Int(nullable: false),
                        FullName = c.String(nullable: false, maxLength: 25),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Stundents");
        }
    }
}
