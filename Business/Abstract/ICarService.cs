using Entities.Abstract;
using Entities.DTo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        void add(Car car);
        void update(Car car);
        List<Car> GetAllByColorId(int ColorId);
        List<Car> GetAllByBrandId(int BrandId);
        List<Car> GetByDailyPrice(int min,int max);
        List<CarDetailDto> GetCarDetails();
    }
}
