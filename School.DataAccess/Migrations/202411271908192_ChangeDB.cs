namespace School.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDB : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Registers", "ClassId", "dbo.Classes");
            DropForeignKey("dbo.Registers", "StudentId", "dbo.Students");
            DropIndex("dbo.Registers", new[] { "StudentId" });
            DropIndex("dbo.Registers", new[] { "ClassId" });
            DropTable("dbo.Classes");
            DropTable("dbo.Registers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Registers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        ClassId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Capacity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Registers", "ClassId");
            CreateIndex("dbo.Registers", "StudentId");
            AddForeignKey("dbo.Registers", "StudentId", "dbo.Students", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Registers", "ClassId", "dbo.Classes", "Id", cascadeDelete: true);
        }
    }
}
