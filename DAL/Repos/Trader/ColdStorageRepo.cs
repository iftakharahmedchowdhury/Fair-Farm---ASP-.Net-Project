using DAL.EF.Models;
using DAL.Interfaces.Trader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Trader
{
    internal class ColdStorageRepo : Repo,ICropsOrder<ColdStorageItemList, int, ColdStorageItemList>
    {
        public ColdStorageItemList Add(ColdStorageItemList obj)
        {
            db.ColdStorageItemLists.Add(obj);
            db.SaveChanges();
            return obj;
        }
    }
}
