using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Ftec.ProjWeb.WatchYourself.Application.Services;
using Ftec.ProjWeb.WatchYourself.Domain.Interfaces.Services;
using Ftec.ProjWeb.WatchYourself.Domain.Models;

namespace Ftec.ProjWeb.WatchYourself.Api.Controllers
{
    public class SmartWatchController : ApiController
    {
        private readonly IStepsService _stepService;
        private readonly IHeartBeatsService _heartBeatService;

        public SmartWatchController()
        {
            _stepService = new StepsService();
            _heartBeatService = new HeartBeatsService();
        }

        [HttpGet]
        public HttpResponseMessage Get(int tste)
        {

            return Request.CreateResponse(HttpStatusCode.InternalServerError);
        }
        public HttpResponseMessage Post([FromBody]SmartWatchData data)
        {
            try
            {
                StringBuilder message = new StringBuilder();

                if(data.STEPS !=0 )
                {
                    var result = _stepService.InsertData(data);
                    if (!result)
                    {
                        message.Append("(Passos não inseridos corretamente)");
                    }
                }
                if(data.HEART_RATE != 0)
                {
                    var result = _heartBeatService.InsertData(data);
                    if (!result)
                    {
                        message.Append("(Frequencia cardiaca não inserida corretamente)");
                    }
                }

                if (string.IsNullOrEmpty(message.ToString()))
                {
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, message.ToString());
                }

            }
            catch (ApplicationException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
