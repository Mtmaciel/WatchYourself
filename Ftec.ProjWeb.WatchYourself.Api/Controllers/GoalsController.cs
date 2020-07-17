using Ftec.ProjWeb.WatchYourself.Application.Services;
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
        private readonly GoalService _goalService;

        public GoalsController()
        {
            _goalService = new GoalService();
        }

        public HttpResponseMessage Get()
        {
            try
            {
                var goals = _goalService.List(Guid.NewGuid());
                return Request.CreateResponse(HttpStatusCode.OK, goals);
            }
            catch (Exception e)
            {

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
            
        }

        public HttpResponseMessage Get(Guid id)
        {
            try 
            {
                var goal = _goalService.Select(id);
                return Request.CreateResponse(HttpStatusCode.OK, goal);
            }
            catch (Exception e)
            {

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        public HttpResponseMessage Post(Goal goal)
        {
            try
            {
                var result = _goalService.Insert(goal);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        public HttpResponseMessage Put(Goal goal)
        {
            try
            {
                var result = _goalService.Update(goal);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        public HttpResponseMessage Delete(Guid id)
        {
            try
            {
                var result = _goalService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
