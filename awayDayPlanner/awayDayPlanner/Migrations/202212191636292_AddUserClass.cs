namespace awayDayPlanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Addresses", "UserID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Addresses", "UserID");
        }
    }
}
