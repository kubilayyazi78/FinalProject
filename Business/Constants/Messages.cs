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
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler listelendi.";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists = "Aynı isimde ürün eklenemez";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
        public static string AuthorizationDenied="İzin yetkisi";
        public static string AccessTokenCreated ="Token Oluştu.";
        public static string UserAlreadyExists="Kullanıcı mevcut.";
        public static string SuccessfulLogin="Giriş başarılı.";
        public static string PasswordError="Şifre hatalı";
        public static string UserNotFound="Kullanıcı bulunamadı.";
        public static string UserRegistered="Kayıt olundu.";
    }
}
