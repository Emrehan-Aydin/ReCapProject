using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTo;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : IEfEntityRepositoryBase<Rental, GalleryContext>, IRentalDal
    {
        public int GetRentalDetail()
        {
            return 0;// coming soon
        }
    }
}

