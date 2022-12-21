namespace awayDayPlanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        ActivityID = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Notes = c.String(maxLength: 200),
                        EstimatedCost = c.Double(nullable: false),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        AwayDay_AwayDayID = c.Int(),
                    })
                .PrimaryKey(t => t.ActivityID)
                .ForeignKey("dbo.AwayDays", t => t.AwayDay_AwayDayID)
                .Index(t => t.AwayDay_AwayDayID);
            
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
                "dbo.AwayDays",
                c => new
                    {
                        AwayDayID = c.Int(nullable: false, identity: true),
                        User_userID = c.Int(),
                    })
                .PrimaryKey(t => t.AwayDayID)
                .ForeignKey("dbo.Users", t => t.User_userID)
                .Index(t => t.User_userID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        userID = c.Int(nullable: false, identity: true),
                        firstname = c.String(nullable: false),
                        lastname = c.String(nullable: false),
                        email = c.String(nullable: false),
                        dob = c.String(nullable: false),
                        phone = c.String(nullable: false),
                        Address_AddressID = c.Int(nullable: false),
                        Login_loginID = c.Int(),
                    })
                .PrimaryKey(t => t.userID)
                .ForeignKey("dbo.Addresses", t => t.Address_AddressID, cascadeDelete: true)
                .ForeignKey("dbo.Logins", t => t.Login_loginID)
                .Index(t => t.Address_AddressID)
                .Index(t => t.Login_loginID);
            
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        loginID = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Salt = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.loginID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Login_loginID", "dbo.Logins");
            DropForeignKey("dbo.AwayDays", "User_userID", "dbo.Users");
            DropForeignKey("dbo.Users", "Address_AddressID", "dbo.Addresses");
            DropForeignKey("dbo.Activities", "AwayDay_AwayDayID", "dbo.AwayDays");
            DropIndex("dbo.Users", new[] { "Login_loginID" });
            DropIndex("dbo.Users", new[] { "Address_AddressID" });
            DropIndex("dbo.AwayDays", new[] { "User_userID" });
            DropIndex("dbo.Activities", new[] { "AwayDay_AwayDayID" });
            DropTable("dbo.Logins");
            DropTable("dbo.Users");
            DropTable("dbo.AwayDays");
            DropTable("dbo.Addresses");
            DropTable("dbo.Activities");
        }
    }
}
