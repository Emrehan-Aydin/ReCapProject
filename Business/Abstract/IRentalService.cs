using Core.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult add(Rental rental);
        IResult update(Rental rental);
        IResult Delete(Rental rental);
        IDataResult<Rental> GetById(int RentalId);
        IDataResult<List<Rental>> GetAll();
    }
}
