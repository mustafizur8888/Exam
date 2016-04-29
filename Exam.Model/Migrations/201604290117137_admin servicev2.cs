namespace Exam.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adminservicev2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdminServices", "Name", c => c.String());
            DropColumn("dbo.AdminServices", "ServiceName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AdminServices", "ServiceName", c => c.String());
            DropColumn("dbo.AdminServices", "Name");
        }
    }
}
