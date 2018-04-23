namespace Technines_irangos_rezervacij.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FillReservationStatuses : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO ReservationStatus (Title, Description, Slug) VALUES ('Laukianti patvirtinimo', 'Rezervacija jau sukurta, tačiau laukianti administratoriaus patvirtinimo.', 'pending')");
            Sql("INSERT INTO ReservationStatus (Title, Description, Slug) VALUES ('Patvirtinta', 'Administratorius patvirtino rezervaciją. Nustatytu laiku galite atvykti pasiimti įrangą.', 'confirmed')");
            Sql("INSERT INTO ReservationStatus (Title, Description, Slug) VALUES ('Šiuo metu aktyvi', 'Šiuo metu įranga pas užsakovą.', 'active')");
            Sql("INSERT INTO ReservationStatus (Title, Description, Slug) VALUES ('Baigta', 'Rezervacija baigta - įranga grąžinta.', 'finished')");
            Sql("INSERT INTO ReservationStatus (Title, Description, Slug) VALUES ('Atšaukta', 'Rezervacija atšaukta užsakovo arba administratoriaus.', 'cancelled')");
            Sql("INSERT INTO ReservationStatus (Title, Description, Slug) VALUES ('Įranga pavogta', 'Užsakovas įrangą pavogė.', 'stolen')");
            Sql("INSERT INTO ReservationStatus (Title, Description, Slug) VALUES ('Įranga apgadinta', 'Užsakovas įrangą apgadino.', 'damaged')");
        }
        
        public override void Down()
        {
        }
    }
}
