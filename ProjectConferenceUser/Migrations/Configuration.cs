namespace ProjectConferenceUser.Migrations
{
    using ProjectConferenceUser.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ConferenceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ConferenceContext context)
        {
            SeedCity(context);
            //SeedConferenceUSer(context);
        }

        private void SeedCity(ConferenceContext context)
        {
            IList<City> defaultCities = new List<City>
            {
                new City() { CityName = "Kraków", PostalCode = "23456" },
                new City() { CityName = "Warszawa", PostalCode = "12456" },
                new City() { CityName = "Katowice", PostalCode = "78965" }
            };

            context.City.AddRange(defaultCities);
            context.SaveChanges();
        }

        private void SeedConferenceUSer(ConferenceContext context)
        {
            context.ConferenceUsers.AddOrUpdate(x => x.Id,

            new ConferenceUser()
            {
                Name = "Jan",
                LastName = "Kowalski",
                Email = "jan@kowalski.pl",
                ConferenceType = eConferenceType.Conference,
                City = new City()
                
            },
            new ConferenceUser()
            {
                Name = "Adam",
                LastName = "Nowak",
                Email = "adam@nowak.pl",
                ConferenceType = eConferenceType.Workshop,
                City = new City()
            });

            context.SaveChanges();
        }
    }
}
