using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Farmer
{
    internal class FarmerPlantingCalenderRepo : Repo, IRepo<PlantingCalendar, int, PlantingCalendar>
    {
        public PlantingCalendar Add(PlantingCalendar obj)
        {
            db.PlantingCalendars.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public bool Delete(int obj)
        {
            var item = db.PlantingCalendars.FirstOrDefault(i => i.Id == obj);
            if (item != null)
            {
                db.PlantingCalendars.Remove(item);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public List<PlantingCalendar> Get()
        {
            return db.PlantingCalendars.ToList();
        }

        public PlantingCalendar Get(int id)
        {
            return db.PlantingCalendars.FirstOrDefault(i => i.Id == id);
        }

        public PlantingCalendar Update(PlantingCalendar obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
            return obj;
        }
    }
}
