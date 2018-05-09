using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Web;

namespace ProjectConferenceUser.Models
{
    public class ConferenceContext : DbContext
    {
        public ConferenceContext(): base("ConferenceConnStr")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ConferenceContext>());
            Database.SetInitializer(new CityDBInitializer());

        }
        public DbSet<ConferenceUser> ConferenceUsers { get; set; }
        public DbSet<City> City { get; set; }

        public System.Data.Entity.DbSet<ProjectConferenceUser.ViewModel.ConferenceUserViewModel> ConferenceUserViewModels { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder) {
        //    modelBuilder.Properties()
        //                .Where(p => p.Name == "City")
        //                .Configure(p => p.IsKey());
        //}
    }
}