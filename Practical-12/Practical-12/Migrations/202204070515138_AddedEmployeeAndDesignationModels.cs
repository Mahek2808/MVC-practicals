namespace Practical_12.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedEmployeeAndDesignationModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Designations",
                c => new
                    {
                        Designation_id = c.Int(nullable: false, identity: true),
                        Desg_Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Designation_id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        MiddleName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        DOB = c.DateTime(nullable: false),
                        Mobile = c.String(nullable: false, maxLength: 10),
                        Address = c.String(nullable: false),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Designation_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Designations", t => t.Designation_id, cascadeDelete: true)
                .Index(t => t.Designation_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Designation_id", "dbo.Designations");
            DropIndex("dbo.Employees", new[] { "Designation_id" });
            DropTable("dbo.Employees");
            DropTable("dbo.Designations");
        }
    }
}
