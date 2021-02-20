using DataAccess.Abstract;
using Entities.Abstract;
using Entities.DTo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> cars;
        public InMemoryCarDal()
        {
            cars = new List<Car> { 
                new Car {Id=1,BrandId=2,ColorId=1,DailyPrice=124000,ModelYear=2012,Description="araba1" }, 
                new Car {Id=2,BrandId=1,ColorId=2,DailyPrice=12000,ModelYear=1994,Description="Araba2" }, 
                new Car {Id=3,BrandId=3,ColorId=0,DailyPrice=150000,ModelYear=2016,Description="Araba3" }, 
                new Car {Id=4,BrandId=4,ColorId=4,DailyPrice=75000,ModelYear=2008,Description="Araba4" } 
            };
        }
        public void Add(Car car)
        {
            cars.Add(car);
        }

        public void Delete(Car car)
        {
            cars.Remove(cars.SingleOrDefault(c=>c.Id==car.Id));
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetail()
        {
            throw new NotImplementedException();
        }

        public void Update(Car Entity)
        {
            Car UpdatedCar = cars.SingleOrDefault(c => c.Id == Entity.Id);
            UpdatedCar.BrandId = Entity.BrandId;
            UpdatedCar.ColorId = Entity.ColorId;
            UpdatedCar.DailyPrice = Entity.DailyPrice;
            UpdatedCar.Description = Entity.Description;
            UpdatedCar.ModelYear = Entity.ModelYear;
        }
    }
}
