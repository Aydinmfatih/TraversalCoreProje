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
    public class Feature2sManager : IFeature2Service
    {
        private readonly IFeature2Dal _feature2Dal;

        public Feature2sManager(IFeature2Dal feature2Dal)
        {
            _feature2Dal = feature2Dal;
        }

        public List<Feature2> GetListByFilter(Expression<Func<Feature2, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Feature2 entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Feature2 entity)
        {
            throw new NotImplementedException();
        }

        public Feature2 TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature2> TGetList()
        {
            return _feature2Dal.GetList();
        }

        public void TUpdate(Feature2 entity)
        {
            throw new NotImplementedException();
        }
    }
}
