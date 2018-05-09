using System;

namespace ProjectConferenceUser.Models
{
    public enum eConferenceType {
        Workshop,
        Conference
    }
    public class ConferenceUser
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public eConferenceType ? ConferenceType { get; set; }
        public City City { get; set; }

        public ConferenceUser()
        {
            Id = Guid.NewGuid();
        }
    }
}