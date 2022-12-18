namespace awayDayPlanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ADPDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        loginID = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.loginID);
            
            AddColumn("dbo.Users", "Login_loginID", c => c.Int());
            CreateIndex("dbo.Users", "Login_loginID");
            AddForeignKey("dbo.Users", "Login_loginID", "dbo.Logins", "loginID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Login_loginID", "dbo.Logins");
            DropIndex("dbo.Users", new[] { "Login_loginID" });
            DropColumn("dbo.Users", "Login_loginID");
            DropTable("dbo.Logins");
        }
    }
}
