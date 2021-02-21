using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public void add(Brand brand)
        {
            _brandDal.Add(brand);
        }
        public void update(Brand brand)
        {
            _brandDal.Update(brand);
        }
        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }
        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int Id)
        {
            return _brandDal.Get(b=>b.Id==Id);
        }
    }
}
