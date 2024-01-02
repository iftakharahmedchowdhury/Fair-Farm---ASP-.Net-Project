using DAL.EF.Models;
using DAL.Interfaces.Trader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Trader
{
    internal class CropsOrderRepo : Repo, ICropsOrder<RequestTableItem, int, RequestTableItem>
    {
        public RequestTableItem Add(RequestTableItem obj)
        {
            db.RequestTableItems.Add(obj);
            db.SaveChanges();
            return obj;
        }
    }
}
