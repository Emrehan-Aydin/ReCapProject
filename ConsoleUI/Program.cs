using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Abstract;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new InMemoryCarDal());
            // carManager.Add(new Car()
            // {
            //     BrandId = 1,
            //     ColorId = 2,
            //     DailyPrice = 1,// uygun kriter 0 dan büyük
            //     Description="ara",//// uygun kriter 2 karakterden fazla
            //     Id =5,ModelYear=1999
            // });

            // foreach (var car in carManager.GetAll())
            // {
            //     Console.WriteLine("{0} {1} {2} {3} {4}",car.Id,car.BrandId,car.ColorId,car.DailyPrice,car.Description);
            // }
            GalleryContext galerycontext = new GalleryContext();
            foreach (var car in galerycontext.Car)
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
