using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {


        public void Delete(T entity)
        {
            using var context = new Context();
            context.Remove(entity);
            context.SaveChanges();

        }

        public List<T> GetList()
        {
            using var context = new Context();
            return context.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            using var context = new Context();
            context.Add(entity);
        }

        public void Update(T entity)
        {
            using var context = new Context();
            context.Update(entity);
        }
    }
}
