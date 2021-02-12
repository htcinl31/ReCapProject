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
        internal static string MaintenanceTime="Sistem Bakımda";
        internal static string CarsListed="Ürünler Listelendi";
    }
}
