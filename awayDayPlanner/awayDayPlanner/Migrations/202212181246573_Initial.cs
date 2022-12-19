namespace awayDayPlanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressID = c.Int(nullable: false, identity: true),
                        Firstline = c.String(nullable: false),
                        SecondLine = c.String(nullable: false),
                        PostCode = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.AddressID);
            
            AddColumn("dbo.Users", "Address_AddressID", c => c.Int());
            CreateIndex("dbo.Users", "Address_AddressID");
            AddForeignKey("dbo.Users", "Address_AddressID", "dbo.Addresses", "AddressID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Address_AddressID", "dbo.Addresses");
            DropIndex("dbo.Users", new[] { "Address_AddressID" });
            DropColumn("dbo.Users", "Address_AddressID");
            DropTable("dbo.Addresses");
        }
    }
}
