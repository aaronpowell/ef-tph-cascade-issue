namespace ClassLibrary1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContactInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        TeacherId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teachers", t => t.TeacherId)
                .Index(t => t.TeacherId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Teacher_Id = c.Int(),
                        Grade = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Id)
                .ForeignKey("dbo.Teachers", t => t.Teacher_Id)
                .Index(t => t.Id)
                .Index(t => t.Teacher_Id);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        TeacherId = c.Int(nullable: false),
                        Department = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "Id", "dbo.People");
            DropForeignKey("dbo.Students", "Teacher_Id", "dbo.Teachers");
            DropForeignKey("dbo.Students", "Id", "dbo.People");
            DropForeignKey("dbo.ContactInfoes", "TeacherId", "dbo.Teachers");
            DropIndex("dbo.Teachers", new[] { "Id" });
            DropIndex("dbo.Students", new[] { "Teacher_Id" });
            DropIndex("dbo.Students", new[] { "Id" });
            DropIndex("dbo.ContactInfoes", new[] { "TeacherId" });
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
            DropTable("dbo.People");
            DropTable("dbo.ContactInfoes");
        }
    }
}
