using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;
        public InMemoryCarDal()
        {
            //Şuan veritabanını simule edioruz.Örneğin, Oracle, Sql Server,MongoDb,Postgres gibi

            _cars = new List<Car> { 
            
                new Car{Id=1,BrandId=2,ColorId=3,DailyPrice=300,CarDescription="LPG",ModelYear=2019,CarName="FIAT"},

                new Car{Id=2,BrandId=3,ColorId=4,DailyPrice=200,CarDescription="DİZEL",ModelYear=2018,CarName="Opel"},

                new Car{Id=3,BrandId=4,ColorId=5,DailyPrice=400,CarDescription="DİZEL",ModelYear=2019,CarName="Peugeot"}

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);

        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()   // burda veritabanındaki (biz şuan liste ile simule ettik) datayı business katmanına gönderiyoruz.
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            //gönderdiğim ürün id 2sine sahip olan listedeki ürünü bul dedik aşağıda
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.Id = car.Id;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.CarDescription = car.CarDescription;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.CarName = car.CarName;
        }
    }
}
