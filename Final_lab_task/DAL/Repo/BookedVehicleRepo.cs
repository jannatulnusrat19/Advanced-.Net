using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class BookedVehicleRepo : IRepo<BookedVehicle, int>
    {
        Easy_TravelsEntities db;
        public BookedVehicleRepo(Easy_TravelsEntities db)
        {
            this.db = db;
        }
        public bool Create(BookedVehicle obj)
        {
            db.BookedVehicles.Add(obj);
            var res = db.SaveChanges();
            return res > 0;
        }

        public bool Delete(int id)
        {
            db.BookedVehicles.Remove(db.BookedVehicles.FirstOrDefault(e => e.TouristID == id));
            var res = db.SaveChanges();
            return res == 0;
        }

        public List<BookedVehicle> Get()
        {
            return db.BookedVehicles.ToList();
        }

        public BookedVehicle Get(int id)
        {
            return db.BookedVehicles.Find(id);
        }

        public bool Update(BookedVehicle obj)
        {
            //var data = db.RoomLists.FirstOrDefault(e => e.Id == obj.Id);
            //data.Name = obj.Name;
            //data.Place = obj.Place;
            //data.Type = obj.Type;
            //data.Price = obj.Price;
            //data.Offer = obj.Offer;
            //data.ExtraInfo = obj.ExtraInfo;
            //db.SaveChanges();
            return true;
        }
    }
}