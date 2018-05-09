using ProjectConferenceUser.BLL;
using ProjectConferenceUser.Models;
using ProjectConferenceUser.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ProjectConferenceUser.Controllers
{
    public class ConferenceUserController : Controller
    {
        private EFConferenceUser _conferenceUser;

        public ConferenceUserController()
        {
            _conferenceUser = new EFConferenceUser();
        }

        // GET: ConferenceUser
        public ActionResult Index()
        {
            return View(_conferenceUser.GetUsers().Select(x => new ConferenceUserViewModel
            {
                Id = x.Id,
                Name = x.Name,
                ConferenceType = x.ConferenceType,
                LastName = x.LastName,
                Email = x.Email,
                CityName = x.City.CityName
            }));
        }

        // GET: ConferenceUser/Create
        public ActionResult Create()
        {
            return View(new AddEditConferenceUserViewModel());
        }

        // POST: ConferenceUser/Create
        [HttpPost]
        public ActionResult Create(AddEditConferenceUserViewModel conferenceUser)
        {
            var user = new ConferenceUser()
            {
                Name = conferenceUser.Name,
                LastName = conferenceUser.LastName,
                Email = conferenceUser.Email,
                ConferenceType = conferenceUser.ConferenceType,
                City = _conferenceUser.GetCity(conferenceUser.CityId)
            };
            _conferenceUser.Add(user);
            return RedirectToAction("Index");

        }

        // GET: ConferenceUser/Edit/5
        public ActionResult Edit(Guid id)
        {
            ConferenceUser conferenceUser = _conferenceUser.GetById(id);
            var vm = new AddEditConferenceUserViewModel()
            {
                Id = id,
                Name = conferenceUser.Name,
                LastName = conferenceUser.LastName,
                Email = conferenceUser.Email,
                ConferenceType = conferenceUser.ConferenceType,
                CityId = conferenceUser.City.Id.ToString()
            };
            return View(vm);
        }

        // POST: ConferenceUser/Edit/5
        [HttpPost]
        public ActionResult Edit(AddEditConferenceUserViewModel conferenceUser)
        {
            var user = new ConferenceUser()
            {
                Id = conferenceUser.Id,
                Name = conferenceUser.Name,
                LastName = conferenceUser.LastName,
                Email = conferenceUser.Email,
                ConferenceType = conferenceUser.ConferenceType,
                City = _conferenceUser.GetCity(conferenceUser.CityId)
            };
            _conferenceUser.Edit(user);
            return RedirectToAction("Index");

        }

        //GET: ConferenceUser/Delete/5
        public ActionResult Delete(Guid id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Delete failed. Try again, and if the problem persists see your system administrator.";
            }
            ConferenceUser conferenceUser = _conferenceUser.GetById(id);
            if (conferenceUser == null)
            {
                return HttpNotFound();
            }
            return View(conferenceUser);
        }

        // POST: ConferenceUser/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id)
        {

            ConferenceUser conferenceUser = _conferenceUser.GetById(id);
            _conferenceUser.Delete(conferenceUser);

            return RedirectToAction("Index");
        }


        public ActionResult Details(Guid id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            ConferenceUser conferenceUser = _conferenceUser.GetById(id);
            var vm = new ConferenceUserViewModel()
            {
                Id = id,
                Name = conferenceUser.Name,
                LastName = conferenceUser.LastName,
                Email = conferenceUser.Email,
                CityName = conferenceUser.City.CityName,
                ConferenceType = conferenceUser.ConferenceType,
                PostalCode = conferenceUser.City.PostalCode
            };

            return View(vm);
        }
    }
}
