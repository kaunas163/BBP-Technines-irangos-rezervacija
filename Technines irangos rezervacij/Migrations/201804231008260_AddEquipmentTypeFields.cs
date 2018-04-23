namespace Technines_irangos_rezervacij.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEquipmentTypeFields : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EquipmentTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EquipmentTypeFields",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Key = c.String(),
                        Value = c.String(),
                        EquipmentTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EquipmentTypes", t => t.EquipmentTypeId, cascadeDelete: true)
                .Index(t => t.EquipmentTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EquipmentTypeFields", "EquipmentTypeId", "dbo.EquipmentTypes");
            DropIndex("dbo.EquipmentTypeFields", new[] { "EquipmentTypeId" });
            DropTable("dbo.EquipmentTypeFields");
            DropTable("dbo.EquipmentTypes");
        }
    }
}
