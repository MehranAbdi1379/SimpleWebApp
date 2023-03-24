namespace SimpleWebApp.DataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "BirthDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writers", "BirthDate");
        }
    }
}
