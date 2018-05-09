using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using ProjectConferenceUser.Models;

namespace ProjectConferenceUser.BLL
{
    public class JSONConferenceUser : IConferenceService
    {
        public void Add(ConferenceUser u) {
            
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(@".\path.json")) {
                serializer.Serialize(sw, u);
            }
        }

        public void Delete(ConferenceUser u) {
            throw new NotImplementedException();
        }

        public void Edit(ConferenceUser u) {
            throw new NotImplementedException();
        }

        public ConferenceUser GetById(Guid Id) {
            throw new NotImplementedException();
        }

        public City GetCity(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ConferenceUser> GetUsers() {
            throw new NotImplementedException();
        }
    }
}