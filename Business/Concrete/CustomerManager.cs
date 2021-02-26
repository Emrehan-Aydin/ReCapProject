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
    public class CustomerManager:ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IResult Add(Customer customer)
        {
            if (customer.CompanyName.Length>2)
            {
                _customerDal.Add(customer);
                return new SuccessResult(Messages.Added);
            }
            else
            {
                return new ErrorResult(Messages.Added);
            }
        }
        public IResult Delete(Customer customer)
        {
            if (customer.CustomerId>0)
            {
                _customerDal.Delete(customer);
                return new SuccessResult(Messages.Deleted);
            }
            else
            {
                return new ErrorResult(Messages.DeleteError);
            }
        }
        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Customer> GetById(int customerId)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(c => c.CustomerId == customerId),Messages.Listed);
        }

        public IResult Update(Customer customer)
        {
            if (customer.CustomerId > 0)
            {
                _customerDal.Update(customer);
                return new SuccessResult(Messages.Updated);
            }
            else
            {
                return new ErrorResult(Messages.UpdateError);
            }
        }
    }
}
