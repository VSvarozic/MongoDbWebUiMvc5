using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MDB.Domain.Model.Abstract;

namespace MDB.WebUi.Controllers
{
    public class TestIocController : Controller
    {
        private IUserProfilesRepository _repository;

        public TestIocController(IUserProfilesRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            ViewBag.TestId = _repository.Id;
            return View();
        }
	}
}