using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.TraderDTO
{
        public class RequestTableDTO
        {
            public int Id { get; set; }
            public string RequestType { get; set; }


            public DateTime Date { get; set; }
            public string Region { get; set; }

            public string Status { get; set; }


            public int UserId { get; set; }


            public List<RequestTableItemDTO> RequestItems { get; set; }
            public List<ColdStorageItemListDTO> ColdStorageRequestItems { get; set; }
        }
    }
