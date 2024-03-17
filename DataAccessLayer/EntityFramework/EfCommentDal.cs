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
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        private readonly Context _context;
        public EfCommentDal(Context context) : base(context)
        {
            _context = context;
        }

        public List<Comment> GetListWithDestination()
        {
            return _context.Comments.Include(x=> x.Destination).ToList();
        }
    }
}
