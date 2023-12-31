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
    public class CropsOrderController : ApiController
    {
        [HttpPost]
        [Route("api/CropRequest/create")]
        public HttpResponseMessage Add(RequestTableItemDTO requestDto)
        {
            try
            {
                CropsOrderService.AddRequestAndItems(requestDto);
                return Request.CreateResponse(HttpStatusCode.OK, "Data added successfully");
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e.Message);
            }
        }

    }
}
