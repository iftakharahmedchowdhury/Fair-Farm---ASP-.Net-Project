﻿using DAL.EF.Models;
using DAL.Interfaces.Farmer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Farmer
{
    internal class FarmerTransportationRentRepo : Repo, ITransportationFleetRentbyFarmer<TransportationFleetRent, int, TransportationFleetRent>
    {
        public TransportationFleetRent Add(TransportationFleetRent obj)
        {
            db.TransportationFleetRents.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public bool Delete(int obj)
        {
            var item = db.TransportationFleetRents.FirstOrDefault(i => i.Id == obj);
            if (item != null)
            {
                db.TransportationFleetRents.Remove(item);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public TransportationFleetRent Getexists(int renterid, int transportregisterid)
        {
            return db.TransportationFleetRents.FirstOrDefault(i => i.Renterid == renterid && i.TransportationFleetRegisterId == transportregisterid && i.Approvestatus == "Pending");

        }
        public TransportationFleetRent Get(int ownerid)
        {
            return db.TransportationFleetRents.FirstOrDefault(i => i.Renterid == ownerid);
        }

        public List<TransportationFleetRent> GetFarmerTransportRentRecords(int ownerid)
        {
            return db.TransportationFleetRents.Where(e => e.Renterid == ownerid).ToList();
        }

        public TransportationFleetRent Update(TransportationFleetRent obj)
        {
            var existingRequest = Get(obj.Id);
            if (existingRequest != null)
            {
                db.Entry(existingRequest).CurrentValues.SetValues(obj);
                db.SaveChanges();
                return existingRequest;
            }
            return null;
        }
    }
}
