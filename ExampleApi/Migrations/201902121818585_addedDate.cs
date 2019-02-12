namespace ExampleApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Quotes", "createdAt", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Quotes", "createdAt");
        }
    }
}
