using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Interfaces.Trader;
using DAL.Repos;
using DAL.Repos.Admin;
using DAL.Repos.Trader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<User, int, User> UserData()
        {

            return new UserRepo();
        }

     

        public static IAuth AuthData()
        {

            return new UserRepo();
        }

        public static IRepo<Token, string, Token> TokenData()
        {
            return new TokenRepo();
        }


        public static IUserIdFormUname GetUserIdData()
        {

            return new UserRepo();
        }
        public static ITransport<TransportationFleetRegister,int,TransportationFleetRegister>TransportContent()
        {
            return new TransportRepo();
        }

        public static ICropsOrder<RequestTableItem, int, RequestTableItem> RequestTableItemData()
        {

            return new CropsOrderRepo();
        }
        public static ICropsOrder<RequestTable, int, RequestTable> RequestTableData()
        {

            return new CropsRequestTableRepo();
        }


        public static IColdStorageRequest<ColdStorageItemList, int, ColdStorageItemList> ColdStorageItemListData()
        {

           return new ColdStorageRepo();
        }
    }
}
