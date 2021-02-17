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


            //AddTest();
        }

        private static void AddTest()
        {
            EfCarDal carDal = new EfCarDal();

            CarManager carManager = new CarManager(carDal);


            Brand brand1 = new Brand();
            brand1.Name = "Fiat";

            Brand brand2 = new Brand();
            brand2.Name = "Mercedes";

            Color color1 = new Color();
            color1.Name = "Sarı";



            Car car1 = new Car();
            car1.Brands.Add(brand2);
            car1.Colors.Add(color1);
            car1.CarName = "Fiat";
            car1.CarDescription = "Manuel Vites";
            car1.DailyPrice = 150;


            Car car2 = new Car();
            car2.Brands.Add(brand1);
            car2.Colors.Add(color1);
            car2.CarName = "Mercedes";
            car2.CarDescription = "Otomatik Vites";
            car2.DailyPrice = 300;


            Console.WriteLine(carManager.Add(car1).Message);
            Console.WriteLine(carManager.Add(car2).Message);






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
