namespace Technines_irangos_rezervacij.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEquipment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Equipments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Description = c.String(),
                        EquipmentTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EquipmentTypes", t => t.EquipmentTypeId, cascadeDelete: true)
                .Index(t => t.EquipmentTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Equipments", "EquipmentTypeId", "dbo.EquipmentTypes");
            DropIndex("dbo.Equipments", new[] { "EquipmentTypeId" });
            DropTable("dbo.Equipments");
        }
    }
}
