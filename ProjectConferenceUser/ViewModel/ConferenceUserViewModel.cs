using ProjectConferenceUser.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectConferenceUser.ViewModel
{
    public class ConferenceUserViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        public string Email { get; set; }
        [Display(Name = "Conference Type")]
        public eConferenceType? ConferenceType { get; set; }
        [Display(Name = "City")]
        public string CityName { get; set; }
        public string PostalCode { get; set; }
    }
}