using ProjectConferenceUser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ProjectConferenceUser.BLL
{
    public class EFConferenceUser : IConferenceService
    {
        private readonly ConferenceContext _conferenceContext;

        public EFConferenceUser() {
            _conferenceContext = new ConferenceContext();
        }

        public void Add(ConferenceUser u)
        {
            _conferenceContext.ConferenceUsers.Add(u);
            _conferenceContext.SaveChanges();
        }

        public void Delete(ConferenceUser u)
        {
            _conferenceContext.ConferenceUsers.Remove(u);
            _conferenceContext.SaveChanges();
        }

        public void Edit(ConferenceUser u)
        {
            //_conferenceContext.ConferenceUsers.Attach(u);
            _conferenceContext.Entry(_conferenceContext.ConferenceUsers.FirstOrDefault(x=>x.Id == u.Id))
                .CurrentValues.SetValues(u);
            _conferenceContext.SaveChanges();
        }

        public ConferenceUser GetById(Guid Id)
        {
            return _conferenceContext.ConferenceUsers.Include(x => x.City).First(x=>x.Id == Id);
        }

        public City GetCity(string id)
        {
            return _conferenceContext.City.FirstOrDefault(x=>x.Id.ToString() == id);
        }

        public IEnumerable<ConferenceUser> GetUsers()
        {
            return _conferenceContext.ConferenceUsers.Include(x => x.City);
        }
    }
}