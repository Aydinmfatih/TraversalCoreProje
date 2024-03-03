using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
  
    public class EfReservationDal : GenericRepository<Reservation>, IReservationDal
    {
        private readonly Context _context;
        public EfReservationDal(Context context) : base(context)
        {
            _context = context;
        }

        public List<Reservation> GetListWithReservationByWaitAccepted(int id)
        {
            return _context.Reservations.Include(x => x.Destination).Where(y => y.Status == "Onaylandı" && y.AppUserId == id).ToList();
        }

        public List<Reservation> GetListWithReservationByWaitApproval(int id)
        {
            return _context.Reservations.Include(x=>x.Destination).Where(y=>y.Status== "Onay Bekliyor" && y.AppUserId == id).ToList();
        }

        public List<Reservation> GetListWithReservationByWaitPrevious(int id)
        {
            return _context.Reservations.Include(x => x.Destination).Where(y => y.Status == "Geçmiş Rezervasyon" && y.AppUserId == id).ToList();
        }
    }
}
