﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces.Farmer
{
    public interface IFarmerAccessRedList<CLASS, ID, Par1>
    {
        List<CLASS> GetByRegion(Par1 region, Par1 type);
        CLASS GetById(ID id, Par1 type);
    }
}
