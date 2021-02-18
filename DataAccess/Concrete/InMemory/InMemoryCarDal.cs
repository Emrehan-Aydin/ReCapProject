using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> Cars;
        public InMemoryCarDal()
        {
            Cars = new List<Car> { 
                new Car {Id=1,BrandId=2,ColorId=1,DailyPrice=124000,ModelYear=2012,Description="araba1" }, 
                new Car {Id=2,BrandId=1,ColorId=2,DailyPrice=12000,ModelYear=1994,Description="Araba2" }, 
                new Car {Id=3,BrandId=3,ColorId=0,DailyPrice=150000,ModelYear=2016,Description="Araba3" }, 
                new Car {Id=4,BrandId=4,ColorId=4,DailyPrice=75000,ModelYear=2008,Description="Araba4" } 
            };
        }
        public void Add(Car car)
        {
            Cars.Add(car);
            GetAll();
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return Cars;
        }

        public List<Car> GetByBrandId(Car Entity)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByColorID(Car Entity)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByID(Car car)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
