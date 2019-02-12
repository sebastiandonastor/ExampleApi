namespace ExampleApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Quotes SET Type = 'Love'");

            AlterColumn("dbo.Quotes", "Title", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Quotes", "Type", c => c.String(nullable: false, maxLength: 25));
            
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Quotes", "Type", c => c.String());
            AlterColumn("dbo.Quotes", "Title", c => c.String());
        }
    }
}
