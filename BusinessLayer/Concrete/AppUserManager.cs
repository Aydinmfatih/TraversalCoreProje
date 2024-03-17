using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public List<AppUser> GetListByFilter(Expression<Func<AppUser, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void TAdd(AppUser entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(AppUser entity)
        {
            throw new NotImplementedException();
        }

        public AppUser TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> TGetList()
        {
           return  _appUserDal.GetList();
        }

        public void TUpdate(AppUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
