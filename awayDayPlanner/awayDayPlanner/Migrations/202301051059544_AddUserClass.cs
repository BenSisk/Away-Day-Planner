namespace awayDayPlanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Address_AddressID", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "Login_loginID", c => c.Int());
            CreateIndex("dbo.Users", "Address_AddressID");
            CreateIndex("dbo.Users", "Login_loginID");
            AddForeignKey("dbo.Users", "Address_AddressID", "dbo.Addresses", "AddressID", cascadeDelete: true);
            AddForeignKey("dbo.Users", "Login_loginID", "dbo.Logins", "loginID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Login_loginID", "dbo.Logins");
            DropForeignKey("dbo.Users", "Address_AddressID", "dbo.Addresses");
            DropIndex("dbo.Users", new[] { "Login_loginID" });
            DropIndex("dbo.Users", new[] { "Address_AddressID" });
            DropColumn("dbo.Users", "Login_loginID");
            DropColumn("dbo.Users", "Address_AddressID");
        }
    }
}
