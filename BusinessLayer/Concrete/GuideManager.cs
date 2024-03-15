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
    public class GuideManager : IGuideService
    {
        private readonly IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public List<Guide> GetListByFilter(Expression<Func<Guide, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Guide entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Guide entity)
        {
            throw new NotImplementedException();
        }

        public Guide TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Guide> TGetList()
        {
          return  _guideDal.GetList();
        }

        public void TUpdate(Guide entity)
        {
            throw new NotImplementedException();
        }
    }
}
