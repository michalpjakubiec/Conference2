using ProjectConferenceUser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectConferenceUser.BLL
{
    public interface IConferenceService
    {
        void Add(ConferenceUser u);
        void Edit(ConferenceUser u);
        void Delete(ConferenceUser u);
        ConferenceUser GetById(Guid Id);
        IEnumerable<ConferenceUser> GetUsers();
        City GetCity(string id);
    }
}