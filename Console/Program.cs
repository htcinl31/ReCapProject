using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //IoC
           // BrandTest();
           //DTO: Data Transformation Object 




        }




        private static void BrandTest()
        {
            BrandManager brandmanager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandmanager.GetAll())
            {
                Console.WriteLine(brand.Name);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.Name);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            
        }
    }
}
