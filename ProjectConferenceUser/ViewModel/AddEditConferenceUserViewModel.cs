using ProjectConferenceUser.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

namespace ProjectConferenceUser.ViewModel
{
    public class AddEditConferenceUserViewModel
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 6)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Compare("Password")]
        [Display(Name = "Confirm password")]
        public string ConfirmPassword { get; set; }
        [Required]
        [Display(Name = "Conference type")]
        public eConferenceType? ConferenceType { get; set; }
        [Required]
        [DisplayName("City")]
        public string CityId { get; set; }
        public IEnumerable<SelectListItem> City { get; set; }
        public AddEditConferenceUserViewModel()
        {
            using (var context = new ConferenceContext())
            {
                City = context.City
                    .Select(x=>new SelectListItem { Text = x.CityName, Value = x.Id.ToString()})
                    .ToArray();
            }
        }
    }
}