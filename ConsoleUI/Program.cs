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
            CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Add(new Car()
            //{
            //    BrandId = 1,
            //    ColorId = 2,
            //    DailyPrice = 1,// uygun kriter 0 dan büyük
            //    Description = "ara",//// uygun kriter 2 karakterden fazla
            //    Id = 5,
            //    ModelYear = 1999
            //});
            carManager.add(new Car() { BrandId = 1, ColorId = 2, DailyPrice = 12001, Description = "araba11" });
            foreach (var item in carManager.GetCarDetails())
            {
                Console.WriteLine("{0} - {1}\t {2}\t {3}\t {4}",item.Id,item.BrandName,item.ColorName,item.CarDailyInPrice,item.CarDescription);
            }

            // GetByDailyPrice(carManager);
        }

        private static void GetByDailyPrice(CarManager carManager)
        {
            foreach (var car in carManager.GetByDailyPrice(57000, 100000))
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", car.Id, car.BrandId, car.ColorId, car.DailyPrice, car.Description);
            }
        }

        private static void CarContextTest()
        {
            GalleryContext galerycontext = new GalleryContext();
            foreach (var car in galerycontext.Car)
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
