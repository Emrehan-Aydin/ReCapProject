using Core.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult add(Customer customer);
        IResult update(Customer customer);
        IResult Delete(Customer customer);
        IDataResult<Customer> GetById(int CustomerId);
        IDataResult<List<Customer>> GetAll();
    }
}
