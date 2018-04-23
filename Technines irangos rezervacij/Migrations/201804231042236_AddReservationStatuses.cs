namespace Technines_irangos_rezervacij.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReservationStatuses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReservationStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Description = c.String(),
                        Slug = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ReservationStatus");
        }
    }
}
