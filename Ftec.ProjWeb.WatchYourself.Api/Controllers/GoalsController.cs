using Ftec.ProjWeb.WatchYourself.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ftec.ProjWeb.WatchYourself.Api.Controllers
{
    public class GoalsController : ApiController
    {
        public HttpResponseMessage Get()
        {
            var goals = new List<Goal>();
            //Chamar aplication
            return Request.CreateResponse(HttpStatusCode.OK, goals);
        }

        public HttpResponseMessage Get(Guid id)
        {
            var goals = new List<Goal>();
            //Chamar aplication
            return Request.CreateResponse(HttpStatusCode.OK, goals);
        }

        public HttpResponseMessage Post(Goal goal)
        {
            var goals = new List<Goal>();
            return Request.CreateResponse(HttpStatusCode.OK, goal.Id);
        }

        public HttpResponseMessage Put(Goal goal)
        {
            var goals = new List<Goal>();
            //Chamar aplication
            return Request.CreateResponse(HttpStatusCode.OK, goal.Id);
        }

        public HttpResponseMessage Delete(Guid id)
        {
            var goals = new List<Goal>();
            //Chamar aplication
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
