using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Admin
{
    internal class ManageTraningRepo : Repo, IRepo<TrainingTable, int, TrainingTable>
    {
        public TrainingTable Add(TrainingTable obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int obj)
        {
            throw new NotImplementedException();
        }

        public List<TrainingTable> Get()
        {
            throw new NotImplementedException();
        }

        public TrainingTable Get(int id)
        {
            throw new NotImplementedException();
        }

        public TrainingTable Update(TrainingTable obj)
        {
            throw new NotImplementedException();
        }
    }
}
