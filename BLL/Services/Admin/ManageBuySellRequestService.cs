using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ManageBuySellRequestService
    {

        public static List<RequestTableDTO> Get()
        {
            var requestData = DataAccessFactory.RequestCropData().Get();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<RequestTable, RequestTableDTO>();
                cfg.CreateMap<RequestTableItem, RequestTableItemDTO>();
            });
            var mapper = new Mapper(config);

            var requestList = mapper.Map<List<RequestTableDTO>>(requestData);

            foreach (var request in requestList)
            {
                var requestItems = new List<RequestTableItemDTO>(); 

                var requestItem = DataAccessFactory.RequestTableItemData().GetItem(request.Id); // get items

                var data2 = mapper.Map<List<RequestTableItemDTO>>(requestItem);
                requestItems.AddRange(data2);

                request.RequestItems = requestItems; // Assign the list to the RequestItems property
            }

            return requestList;
        }


        public static void AddRequestAndItems(RequestTableDTO requestDto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<RequestTableDTO, RequestTable>();
                cfg.CreateMap<RequestTableItemDTO, RequestTableItem>();
            });
            var mapper = new Mapper(config);

            var requestEntity = mapper.Map<RequestTable>(requestDto);

            var addedRequest = DataAccessFactory.RequestCropData().Add(requestEntity);

            var requestItems = requestDto.RequestItems.Select(itemDto => mapper.Map<RequestTableItem>(itemDto)).ToList();
            foreach (var requestItem in requestItems)
            {
                requestItem.RequestId = addedRequest.Id;
                DataAccessFactory.RequestTableItemData().Add(requestItem);
            }
        }

       
        public static void UpdateStatusAndAddItems(int requestId)
        {
            var request = DataAccessFactory.RequestCropData().Get(requestId);

            if (request != null)
            {
                
                request.Status = "Accepted"; // Update the status to "Accepted"
                DataAccessFactory.RequestCropData().Update(request);

                var requestItems = DataAccessFactory.RequestTableItemData().GetItem(requestId);

                var config = new MapperConfiguration(cfg => cfg.CreateMap<RequestTableItem, AdminStoredItem>());
                var mapper = new Mapper(config);

                foreach (var item in requestItems)
                {
                    var adminStoredItem = mapper.Map<AdminStoredItem>(item);
                    adminStoredItem.StorageRequestId = requestId;

                    DataAccessFactory.AdminStoredItemData().Add(adminStoredItem); // Add items to AdminStoredItems table
                }
            }
        }






    }
}
