using BLL.Services.Trader;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Fair_Farm.Controllers.Trader
{
    public class ColdStorageRequestController : ApiController
    {
        [HttpPost]
        [Route("api/ColdStorageRequest/create")]
        public HttpResponseMessage Add(ColdStorageItemListDTO requestDto)
        {
            try
            {
                ColdStorageService.AddRequestAndItems(requestDto);
                return Request.CreateResponse(HttpStatusCode.OK, "Request Sent successfully");
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e.Message);
            }
        }
    }
}
