using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "URUN EKLENDI";
        public static string ProductNameInvalid = "URUN ISMI GECERSIZ";
        public static string MaintenanceTime = "SISTEM BAKIMDA";
        public static string ProductsListed = " URUNLER LISTELENDI";
        public static string ProductDeleted = "URUN SILINDI";
        public static string ProductCountOfCategoryError = "BIR KATEGORIDE EN FAZLA 10 URUN BULUNABİLİR";

        public static string ProductNameAlreadyExists = "BU ISIMDE URUN BULUNMAKTADIR";

        public static string CategoryAdded = "KATEGORI EKLENDI";

        public static string CategoryCountError = "KATEGORI SAYISINDAN DOLAYI EKLENEMEDI";
        public static string AuthorizationDenied = "YETKINIZ YOK";

        public static string UserRegistered = "KAYIT OLUNDU";
        public static string UserNotFound = "KULLANICI BULUNAMADI";
        public static string PasswordError = "PAROLA HATASI";
        public static string SuccessfulLogin = "GIRIS BASARILI";
        public static string UserAlreadyExists = "KULLANICI MEVCUT";
        public static string AccessTokenCreated = "TOKEN OLUSTURULDU";
    }
}
