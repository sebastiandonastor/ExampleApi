namespace ExampleApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Quotes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Author = c.String(),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.Id);

            Sql("INSERT INTO Quotes (Title, Author, Content) VALUES ('A title hihihi','Sebastian Donastor','Life is like a box of chocolate')");
            Sql("INSERT INTO Quotes (Title ,Author, Content) VALUES ('Best Quote Ever','Sebastian Sezastian','The best thing in the world is a hug')");

        }

        public override void Down()
        {
            Sql("DELETE QUOTE WHERE ID BETWEEN 1 AND 2");
            DropTable("dbo.Quotes");
        }
    }
}
