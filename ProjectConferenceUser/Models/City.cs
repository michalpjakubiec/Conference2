using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectConferenceUser.Models
{
    public class City
    {
        public Guid Id { get; set; }
        public string CityName { get; set; }
        public string PostalCode { get; set; }

        public City()
        {
            Id = Guid.NewGuid();
        }

    }
 
}