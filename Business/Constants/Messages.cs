using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

//AOP: aspect oriented programming

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime ="Sistem bakımda";
        public static string ProductsListed ="Ürünler listelendi";
        public static string Listed = "Listelendi.";
        public static string ProductCountOfCategoryError = "Bu kategoride en fazla bu kadar ürün olabilir.";
        public static string ProductNameAlreadyExist = "Aynı isimde ürün eklenemez";
        public static string CategoryCountLimitation = "Kategori sayısı limite ulaştı. Limit: ";
    }
}
