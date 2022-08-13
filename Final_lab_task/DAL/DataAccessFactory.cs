using DAL.EF;
using DAL.Interfaces;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static Easy_TravelsEntities db = new Easy_TravelsEntities();
        public static IRepo<Accountant, int> GetAccountantDataAccess()
        {
           return new AccountantRepo(db);
        }
        public static IRepo<BookedVehicle, int> GetBookedVehicleDataAccess()
        {
           return new BookedVehicleRepo(db);
        }
        public static IRepo<Inq, int> GetInqDataAccess()
        {
            return new InqRepo(db);
        }
    }
}
