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
    public class UserManager:IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IResult Add(User user)
        {
            if (user.FirstName.Length > 2)
            {
                _userDal.Add(user);
                return new SuccessResult(Messages.Added);
            }
            else
            {
                return new ErrorResult(Messages.Added);
            }
        }
        public IResult Delete(User user)
        {
            if (user.Password.Length > 7)
            {
                _userDal.Delete(user);
                return new SuccessResult(Messages.Deleted);
            }
            else
            {
                return new ErrorResult(Messages.DeleteError);
            }
        }
        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.Listed);
        }

        public IDataResult<User> GetById(int customerId)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.Id == customerId), Messages.Listed);
        }

        public IResult Update(User user)
        {
            if (user.Id > 0)
            {
                _userDal.Update(user);
                return new SuccessResult(Messages.Updated);
            }
            else
            {
                return new ErrorResult(Messages.UpdateError);
            }
        }
    }
}
