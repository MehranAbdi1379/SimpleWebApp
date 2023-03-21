namespace SimpleWebApp.DataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTheDataBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Writers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Writers");
        }
    }
}
