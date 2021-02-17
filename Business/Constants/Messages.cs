using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //CarAdded ve CarNameınvalid değişkendir.Değişkenlerin ilk harfleri küçük olur ama public old.için bunların ilk harfi büyük yazıldı.

        public static string CarAdded = "Araç Eklendi";
        public static string CarNameInvalid = "Araç İsmi Geçersiz";
        public static string MaintenanceTime="Sistem Bakımda";
        public static string CarsListed="Araçlar Listelendi";

        public static string AddedBrand = "Marka başarıyla eklendi.";
        public static string DeletedBrand = "Marka başarıyla silindi.";
        public static string UpdatedBrand = "Marka başarıyla güncellendi.";
        public static string FailedBrandAddOrUpdate = "Lütfen marka isminin uzunluğunu 2 karakterden fazla giriniz.";



        public static string AddedRental = "Araba Kiralama işlemi baraşıyla gerçekleşti.";
        public static string DeletedRental = "Araba Kiralama işlemi iptal edildi.";
        public static string UpdatedRental = "Araba Kiralama işlemi güncellendi.";
        public static string FailedRentalAddOrUpdate = "Bu araba henüz teslim edilmediği için kiralayamazsınız.";
        public static string ReturnedRental = "Kiraladığınız araç teslim edildi.";



        public static string AddedColor = "Renk başarıyla eklendi.";
        public static string DeletedColor = "Renk başarıyla silindi.";
        public static string UpdatedColor = "Renk başarıyla güncellendi.";

        public static string AddedCustomer = "Müşteri başarıyla eklendi.";
        public static string DeletedCustomer = "Müşteri başarıyla silindi.";
        public static string UpdatedCustomer = "Müşteri başarıyla güncellendi.";


        public static string AddedUser = "Kullanıcı başarıyla eklendi.";
        public static string DeletedUser = "Kullanıcı başarıyla silindi.";
        public static string UpdatedUser = "Kullanıcı başarıyla güncellendi.";

    }
}
