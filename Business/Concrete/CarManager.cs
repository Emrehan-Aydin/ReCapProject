using Business.Abstract;
using Business.Constant;
using Core.Result;
using DataAccess.Abstract;
using Entities.Abstract;
using Entities.DTo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public IResult Add(Car car)
        {
            if (car.Description.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.Added);
            }
            else
            {
                return new ErrorResult(Messages.Added);
            }
        }
        public IResult Delete(Car car)
        {
            if (car.Id > 0 && car.Description.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Delete(car);
                return new SuccessResult(Messages.Deleted);
            }
            else
            {
                return new ErrorResult(Messages.DeleteError);
            }
        }
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.Listed);
        }
        public IDataResult<List<Car>> GetAllByBrandId(int BrandId)
        {
            if (BrandId > 0)
            {
                return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == BrandId), Messages.Listed);
            }
            else
            {
                return new ErrorDataResult<List<Car>>(Messages.ListeError);
            }
        }
        public IDataResult<List<Car>> GetAllByColorId(int ColorId)
        {
            if (ColorId > 0)
            {
                return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == ColorId), Messages.Listed);
            }
            else
            {
                return new ErrorDataResult<List<Car>>(Messages.ListeError);
            }
        }

        public IDataResult<List<Car>> GetByDailyPrice(int min, int max)
        {
            if (min < max)
            {
                return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max), Messages.Listed);
            }
            else
            {
                return new SuccessDataResult<List<Car>>(Messages.ListeError);
            }
        }
        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetail(), Messages.Listed);
        }
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.Updated);
        }
    }
}
