namespace awayDayPlanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressID = c.Int(nullable: false, identity: true),
                        FirstLine = c.String(),
                        SecondLine = c.String(),
                        PostCode = c.String(),
                    })
                .PrimaryKey(t => t.AddressID);
            
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        loginID = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.loginID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        userID = c.Int(nullable: false, identity: true),
                        firstname = c.String(),
                        lastname = c.String(),
                        email = c.String(),
                        dob = c.String(),
                        phone = c.String(),
                        Address_AddressID = c.Int(),
                        Login_loginID = c.Int(),
                    })
                .PrimaryKey(t => t.userID)
                .ForeignKey("dbo.Addresses", t => t.Address_AddressID)
                .ForeignKey("dbo.Logins", t => t.Login_loginID)
                .Index(t => t.Address_AddressID)
                .Index(t => t.Login_loginID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Login_loginID", "dbo.Logins");
            DropForeignKey("dbo.Users", "Address_AddressID", "dbo.Addresses");
            DropIndex("dbo.Users", new[] { "Login_loginID" });
            DropIndex("dbo.Users", new[] { "Address_AddressID" });
            DropTable("dbo.Users");
            DropTable("dbo.Logins");
            DropTable("dbo.Addresses");
        }
    }
}
