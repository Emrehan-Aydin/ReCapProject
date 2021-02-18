using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car newcar)
        {
            if(newcar.Description.Length > 2 && newcar.DailyPrice>0)
            {
                _carDal.Add(newcar);
            }
            else
            {
                Console.WriteLine("Eklemeye çalıştığınız araç kriterleri uygun değil!");
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Update(Car updated)
        {
            if (updated.Description.Length > 2 && updated.DailyPrice < 0)
            {
                _carDal.Update(updated);
            }
            else
            {
                Console.WriteLine("Güncelleştirmeye çalıştığınız araç kriterleri uygun değil!");
            }
        }
    }
}
