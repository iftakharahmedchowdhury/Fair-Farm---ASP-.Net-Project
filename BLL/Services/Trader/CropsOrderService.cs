using AutoMapper;
using BLL.DTOs.TraderDTO;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces.Trader;

namespace BLL.Services.Trader
{
    public class CropsOrderService
    {

        public static void AddRequestAndItems(DTOs.TraderDTO.RequestTableDTO requestDto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DTOs.TraderDTO.RequestTableDTO, RequestTable>();
                cfg.CreateMap<RequestTableItemDTO, RequestTableItem>();
            });
            var mapper = new Mapper(config);

            var requestEntity = mapper.Map<RequestTable>(requestDto);

            var addedRequest = DataAccessFactory.RequestTableItemData().Add(requestEntity);

            var requestItems = requestDto.RequestItems.Select(itemDto => mapper.Map<RequestTableItem>(itemDto)).ToList();
            foreach (var requestItem in requestItems)
            {
                requestItem.RequestId = addedRequest.Id;
                DataAccessFactory.RequestTableItemData().Add(requestItem);

            }
        }
    }
    }
