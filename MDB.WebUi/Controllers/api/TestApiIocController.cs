using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MDB.Domain.Model.Abstract;

namespace MDB.WebUi.Controllers.api
{
    public class TestApiIocController : ApiController
    {
        private readonly IUserProfilesRepository _repository;

        public TestApiIocController(IUserProfilesRepository repository)
        {
            _repository = repository;
        }

        public string[] Get()
        {
            return new[] {_repository.Id.ToString("c"), "first string", "second string"};
        }
    }
}
