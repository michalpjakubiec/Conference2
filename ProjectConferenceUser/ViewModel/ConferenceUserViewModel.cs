using ProjectConferenceUser.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectConferenceUser.ViewModel
{
    public class ConferenceUserViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        public string Email { get; set; }
        [Display(Name = "Conference type")]
        public eConferenceType? ConferenceType { get; set; }
        [Display(Name = "City")]
        public string CityName { get; set; }
        [Display(Name = "City postal code")]
        public string PostalCode { get; set; }
    }
}