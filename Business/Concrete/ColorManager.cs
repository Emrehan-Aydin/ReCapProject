using Business.Abstract;
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
        public void add(Color color)
        {
            _colorDal.Add(color);
        }
        public void update(Color color)
        {
            _colorDal.Update(color);
        }
        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }
        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetById(int Id)
        {
            return _colorDal.Get(c => c.Id == Id);
        }
    }
}
