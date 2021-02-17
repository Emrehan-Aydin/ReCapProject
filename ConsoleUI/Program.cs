using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0} {1} {2} {3} {4}",car.Id,car.BrandId,car.ColorId,car.DailyPrice,car.Description);
            }
        }
    }
}
