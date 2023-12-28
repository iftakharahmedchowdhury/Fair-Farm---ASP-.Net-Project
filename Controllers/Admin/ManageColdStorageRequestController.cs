using BLL.DTOs;
using BLL.Services;
using BLL.Services.Admin;
using Fair_Farm.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Fair_Farm.Controllers.Admin
{
    public class ManageColdStorageRequestController : ApiController
    {
        [AdminAccess]

        [HttpGet]
        [Route("api/ColdStorageRequest/all")]
        public HttpResponseMessage All()
        {
            try
            {
                var data = ManageColdStorageRequestService.GetColdStorageRequest();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e.Message);

            }
        }

  /*      [Logged]
        [HttpPost]
        [Route("api/ColdStorageRequest/create")]
        public HttpResponseMessage Add(RequestTableDTO requestDto)
        {
            try
            {
                ManageBuySellRequestService.AddRequestAndItems(requestDto);
                return Request.CreateResponse(HttpStatusCode.OK, "Data added successfully");
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e.Message);
            }
        }*/

        [AdminAccess]
        [HttpPut]
        [Route("api/ColdStorageRequest/adminAccept/{requestId}")]
        public HttpResponseMessage UpdateStatusAndAddItemsInColdStorage(int requestId)
        {
            try
            {
                ManageColdStorageRequestService.UpdateStatusAndAddItemsInColdStorage(requestId);
                return Request.CreateResponse(HttpStatusCode.OK, "Request Accepted and Item stored in cold storage");
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e.Message);
            }
        }

        [AdminAccess]
        [HttpPut]
        [Route("api/ColdStorageRequest/adminNotAccept/{requestId}")]
        public HttpResponseMessage UpdateStatusAndAdminRejected(int requestId)
        {
            try
            {
                ManageColdStorageRequestService.UpdateStatusAndAdminRejected(requestId);
                return Request.CreateResponse(HttpStatusCode.OK, "Not accepted request");
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e.Message);
            }

        }



    }
}
