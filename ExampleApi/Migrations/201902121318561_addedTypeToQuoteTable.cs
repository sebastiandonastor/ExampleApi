namespace ExampleApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedTypeToQuoteTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Quotes", "Type", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Quotes", "Type");
        }
    }
}
