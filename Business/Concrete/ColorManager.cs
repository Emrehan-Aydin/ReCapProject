using Business.Abstract;
using Business.Constant;
using Core.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager:IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult(Messages.Added);
        }
        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult(Messages.Updated);
        }
        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.Deleted);
        }
        public IDataResult<List<Color>>GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(),Messages.Listed);
        }

        public IDataResult<Color> GetById(int Id)
        {
            if (Id > 0)
            {
                return new SuccessDataResult<Color>(_colorDal.Get(c => c.Id == Id), Messages.Listed);
            }
            else
            {
                return new ErrorDataResult<Color>(Messages.ListeError);
            }
        }
    }
}
