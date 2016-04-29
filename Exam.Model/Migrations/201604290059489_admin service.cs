namespace Exam.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adminservice : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminServices",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ServiceName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.ExamClasses");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ExamClasses",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.AdminServices");
        }
    }
}
