namespace Exam.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class exam1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExamClasses",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ExamClasses");
        }
    }
}
