using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Farmer
{
    public class FarmerPlantingCalenderService
    {
        public static List<PlantingCalendarDTO> Get()
        {
            var data = DataAccessFactory.RegularPriceData().Get();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PlantingCalendar, PlantingCalendarDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<PlantingCalendarDTO>>(data);
        }

    }
}
