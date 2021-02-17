using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    interface ICarDal
    {
        void GetByID(Car car);
        void GetAll(Car car);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
