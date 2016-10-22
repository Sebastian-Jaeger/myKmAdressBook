namespace myKmAdressBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustumerId = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        Postcode = c.String(nullable: false),
                        City = c.String(nullable: false),
                        Country = c.String(nullable: false),
                        Street = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Adresses");
        }
    }
}
