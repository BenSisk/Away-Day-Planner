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
                        Name = c.String(nullable: false),
                        Notes = c.String(maxLength: 200),
                        ActualCost = c.Double(nullable: false),
                        Type_ActivityTypeID = c.Int(nullable: false),
                        AwayDay_AwayDayID = c.Int(),
                    })
                .PrimaryKey(t => t.ActivityID)
                .ForeignKey("dbo.ActivityTypes", t => t.Type_ActivityTypeID, cascadeDelete: true)
                .ForeignKey("dbo.AwayDays", t => t.AwayDay_AwayDayID)
                .Index(t => t.Type_ActivityTypeID)
                .Index(t => t.AwayDay_AwayDayID);
            
            CreateTable(
                "dbo.ActivityTypes",
                c => new
                    {
                        ActivityTypeID = c.Int(nullable: false, identity: true),
                        ActivityTypeName = c.String(nullable: false),
                        ActivityTypeEstimatedPrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ActivityTypeID);
            
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
                        AwayDayDate = c.DateTime(nullable: false),
                        Confirmed = c.Boolean(nullable: false),
                        CanBeConfirmed = c.Boolean(nullable: false),
                        TotalCost = c.Double(nullable: false),
                        User_userID = c.Int(),
                        User_userID1 = c.Int(),
                    })
                .PrimaryKey(t => t.AwayDayID)
                .ForeignKey("dbo.Users", t => t.User_userID)
                .ForeignKey("dbo.Users", t => t.User_userID1)
                .Index(t => t.User_userID)
                .Index(t => t.User_userID1);
            
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
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        userID = c.Int(nullable: false, identity: true),
                        firstname = c.String(nullable: false),
                        lastname = c.String(nullable: false),
                        email = c.String(nullable: false),
                        dob = c.DateTime(nullable: false),
                        phone = c.Int(nullable: false),
                        isAdmin = c.Boolean(nullable: false),
                        Login_loginID = c.Int(),
                    })
                .PrimaryKey(t => t.userID)
                .ForeignKey("dbo.Logins", t => t.Login_loginID)
                .Index(t => t.Login_loginID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Login_loginID", "dbo.Logins");
            DropForeignKey("dbo.AwayDays", "User_userID1", "dbo.Users");
            DropForeignKey("dbo.AwayDays", "User_userID", "dbo.Users");
            DropForeignKey("dbo.Activities", "AwayDay_AwayDayID", "dbo.AwayDays");
            DropForeignKey("dbo.Activities", "Type_ActivityTypeID", "dbo.ActivityTypes");
            DropIndex("dbo.Users", new[] { "Login_loginID" });
            DropIndex("dbo.AwayDays", new[] { "User_userID1" });
            DropIndex("dbo.AwayDays", new[] { "User_userID" });
            DropIndex("dbo.Activities", new[] { "AwayDay_AwayDayID" });
            DropIndex("dbo.Activities", new[] { "Type_ActivityTypeID" });
            DropTable("dbo.Users");
            DropTable("dbo.Logins");
            DropTable("dbo.AwayDays");
            DropTable("dbo.Addresses");
            DropTable("dbo.ActivityTypes");
            DropTable("dbo.Activities");
        }
    }
}
