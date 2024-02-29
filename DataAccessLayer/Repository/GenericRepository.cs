using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly Context _context;

        public GenericRepository(Context context)
        {
            _context = context;
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();

        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);

        }

        public List<T> GetList()
        {
          
            return _context.Set<T>().ToList();
        }

        public List<T> GetListByFilter(Expression<Func<T, bool>> filter)
        {
            return _context.Set<T>().Where(filter).ToList();
        }

        public void Insert(T entity)
        {

            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {

            _context.Update(entity);
        }
    }
}
