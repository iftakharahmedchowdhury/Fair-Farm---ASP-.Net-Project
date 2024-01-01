using BLL.DTOs;
using BLL.Services.Trader;
using System;
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
