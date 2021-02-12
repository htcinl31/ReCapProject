using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {

        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public List<Brand> GetAll()
        {
            //iş kodları

            return _brandDal.GetAll();
        }

        //select* from Brands where Id=3 // 3 dediğimiz kullanıcı ne gönderirse o bu da brandId dediğimiz parametrede tutulacak
        public Brand GetById(int brandId)
        {
            return _brandDal.Get(b => b.Id == brandId);
        }
    }
}
