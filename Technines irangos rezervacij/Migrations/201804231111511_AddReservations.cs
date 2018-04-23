namespace Technines_irangos_rezervacij.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReservations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TimeFrom = c.DateTime(nullable: false),
                        TimeTo = c.DateTime(nullable: false),
                        ReservationStatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ReservationStatus", t => t.ReservationStatusId, cascadeDelete: true)
                .Index(t => t.ReservationStatusId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "ReservationStatusId", "dbo.ReservationStatus");
            DropIndex("dbo.Reservations", new[] { "ReservationStatusId" });
            DropTable("dbo.Reservations");
        }
    }
}
