using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Abstract;
using Entities.DTo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : IEfEntityRepositoryBase<Car, GalleryContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetail()
        {
            using (GalleryContext galleryContext = new GalleryContext())
            {
                var result = from c in galleryContext.Car
                             join co in galleryContext.Color
                             on c.ColorId equals co.Id
                             join b in galleryContext.Brand
                             on c.BrandId equals b.Id
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandName = b.Name,
                                 ColorName = co.Name,
                                 CarDailyInPrice = c.DailyPrice,
                                 CarDescription = c.Description

                             };
                return result.ToList();

            }

        }
    }
}

