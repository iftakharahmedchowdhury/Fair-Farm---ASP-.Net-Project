﻿using BLL.DTOs;
using BLL.Services;
using Fair_Farm.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Fair_Farm.Controllers.Admin
{
    public class ManageBuySellRequestController : ApiController
    {
        [AdminAccess]

        [HttpGet]
        [Route("api/CropRequest/all")]
        public HttpResponseMessage All()
        {
            try
            {
                var data = ManageBuySellRequestService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e.Message);

            }
        }

        [AdminAccess]
        [HttpPost]
        [Route("api/CropRequest/create")]
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
        }

        [AdminAccess]
        [HttpPut]
        [Route("api/CropRequest/updateStatusAndAddItems/{requestId}")]
        public HttpResponseMessage UpdateStatusAndAddItems(int requestId)
        {
            try
            {
                ManageBuySellRequestService.UpdateStatusAndAddItems(requestId);
                return Request.CreateResponse(HttpStatusCode.OK, "Status updated to 'Accepted' and items added to AdminStoredItems");
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e.Message);
            }
        }





    }
}
