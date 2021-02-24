using Core.Result;
using Entities.Abstract;
using Entities.DTo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult add(Car car);
        IResult update(Car car);
        IResult Delete(Car car);
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetAllByColorId(int ColorId);
        IDataResult<List<Car>> GetAllByBrandId(int BrandId);
        IDataResult<List<Car>> GetByDailyPrice(int min,int max);
        IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}
