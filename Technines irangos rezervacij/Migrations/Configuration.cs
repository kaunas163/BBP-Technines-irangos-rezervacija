using Technines_irangos_rezervacij.Models;

namespace Technines_irangos_rezervacij.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Technines_irangos_rezervacij.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Technines_irangos_rezervacij.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Notifications.AddOrUpdate(x => x.Id,
                new Notification
                {
                    Id = 1,
                    Topic = "Sveiki!",
                    Text = "Sveiki u�suk?. Pirmiausiai rekomenduojame susipa�inti su m?s? turima ?ranga paspaudus ant [linkas]. Nor?dami rezervuotis ?ranga turite susipa�inti su taisykl?mis..........",
                    IsArchived = true,
                    DateCreated = DateTime.Now,
                    DateRead = null
                },
                new Notification
                {
                    Id = 2,
                    Topic = "Pakeistas rezervacijos statusas",
                    Text = "Rezervacijai ID: 452 pakeistas statusas i� 'Laukianti patvirtinimo' ? 'Aktyvi'.",
                    IsArchived = false,
                    DateCreated = DateTime.Now,
                    DateRead = null
                },
                new Notification
                {
                    Id = 3,
                    Topic = "Rezervacija atnaujinta",
                    Text = "J?s s?kmingai pakeit?te kamer? i� Nikon 3500D ? Canon EOS 70D",
                    IsArchived = true,
                    DateCreated = DateTime.Now,
                    DateRead = DateTime.Now
                },
                new Notification
                {
                    Id = 4,
                    Topic = "Nauja kamera!",
                    Text = "D�iaugiam?s gav? nauj? kamer? Red pppp. Nor?dami j? rezervuoti spauskite [?ia].",
                    IsArchived = false,
                    DateCreated = DateTime.Now,
                    DateRead = DateTime.Now
                },
                new Notification
                {
                    Id = 5,
                    Topic = "Naujas ?rangos komplektas nuomai",
                    Text = "Suk?r?me nauj? ?rangos komplekt?. Komplektas yra skirtas pradedantiesiems, tod?l nereik?s vargti su dideliu kiekiu nustatym?.",
                    IsArchived = true,
                    DateCreated = DateTime.Now,
                    DateRead = DateTime.Now
                },
                new Notification
                {
                    Id = 6,
                    Topic = "Nauja rezervacija sukurta",
                    Text = "S?kmingai suk?r?te nauj? rezervacij? komplektui ID: 332. Rezervacijos statusas yra 'Laukianti patvirtinimo'.",
                    IsArchived = false,
                    DateCreated = DateTime.Now,
                    DateRead = null
                },
                new Notification
                {
                    Id = 7,
                    Topic = "Pakeistas rezervacijos statusas",
                    Text = "Rezervacijai ID: 1425 pakeistas statusas i� 'Aktyvi' ? 'Baigta'.",
                    IsArchived = true,
                    DateCreated = DateTime.Now,
                    DateRead = DateTime.Now
                });
        }
    }
}
