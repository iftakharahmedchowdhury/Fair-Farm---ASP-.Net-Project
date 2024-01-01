using AutoMapper;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOs;

namespace BLL.Services.Trader
{
    public class ColdStorageService
    {
        public static void AddRequestAndItems(ColdStorageItemListDTO requestDto)
        {
            var config = new MapperConfiguration(cfg =>
            {
               cfg.CreateMap<RequestTableDTO, RequestTable>();
               cfg.CreateMap<ColdStorageItemListDTO, ColdStorageItemList>();
            });
            var mapper = new Mapper(config);

            var requestEntity = mapper.Map<ColdStorageItemList>(requestDto);

            var addedRequest = DataAccessFactoryTrader.ColdStorageItemListData().Add(requestEntity);

            /*var requestItems = requestDto.RequestItems.Select(itemDto => mapper.Map<ColdStorageItemList>(itemDto)).ToList();
            foreach (var requestItem in requestItems)
            {
                requestItem.RequestId = addedRequest.Id;
                DataAccessFactoryTrader.ColdStorageItemListData().Add(requestItem);

            }*/
        }
    }
}

    
   
