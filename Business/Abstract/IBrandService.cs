using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{

    //Brand(marka) ile ilgili dış dünyaya neyi servis etmek istiyorsak onu yazıyoruz
    public interface IBrandService
    {

        List<Brand> GetAll();

        Brand GetById(int brandId);
    }
}
