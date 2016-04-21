namespace Exam.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableNamepropertyAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Name");
        }
    }
}
