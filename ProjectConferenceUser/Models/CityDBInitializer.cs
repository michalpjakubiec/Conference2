using System.Collections.Generic;
using System.Data.Entity;

namespace ProjectConferenceUser.Models
{
    public class CityDBInitializer : DropCreateDatabaseIfModelChanges<ConferenceContext>
    {
        protected override void Seed(ConferenceContext context) {
            IList<City> defaultCities = new List<City> {
                new City() { CityName = "Warszawa", PostalCode = "00-000" },
                new City() { CityName = "Bielsko-Biała", PostalCode = "43-300" },
                new City() { CityName = "Kraków", PostalCode = "12-345" },
                new City() { CityName = "Cieszyn", PostalCode = "66-666" }
            };

            context.City.AddRange(defaultCities);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}