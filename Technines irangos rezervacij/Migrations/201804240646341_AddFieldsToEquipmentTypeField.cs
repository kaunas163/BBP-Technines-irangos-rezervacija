namespace Technines_irangos_rezervacij.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFieldsToEquipmentTypeField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EquipmentTypeFields", "ValuePlaceholder", c => c.String());
            AddColumn("dbo.EquipmentTypeFields", "Explanation", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.EquipmentTypeFields", "Explanation");
            DropColumn("dbo.EquipmentTypeFields", "ValuePlaceholder");
        }
    }
}
