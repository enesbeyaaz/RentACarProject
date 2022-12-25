using Core.DataAccess.Concrete;
using Entities.Constrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarsListed = "Arabalar Listelendi.";
        public static string CarDeleted = "Araba silindi.";
        public static string CarAdded = "Araba eklendi.";
        public static string CarAddError = "Araba ismi 2 veya 2 karakterin üzerinde ve Günlük ücret 0'ın üzerinde olmalıdır";
        public static string CarUpdated = "Araba güncellendi.";
        public static string UserAdded = "Kullanıcı Eklendi.";
        public static string UserDeleted = "Kullanıcı silindi.";
        public static string UsersListed = "Kullanıcılar Listelendi.";
        public static string UserListed = "Kullannıcı Listelendi.";
        public static string UserUpdated = "Kullanıcı güncellendi";

        public static string RentalAdded = "Kiralama Eklendi.";

        public static string CarImageAdded="Araba Fotoğrafı Eklendi";
        public static string CarImageDeleted = "Araba Fotoğrafı Silindi.";
        public static string CarImagesListed = "Araba Fotoğrafları Listelendi.";

        public static string UserNotFound = "Kullanıcı Bulanamadı";

        public static string PasswordError = "Şifre Hatalı.";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExist="Kullanıcı Mevcut";
        public static string AccessTokenCreated="Access Token Oluşturuldu";

        public static string AuthorizationDenied = "Yetkiniz yok!";

        public static string BrandAdded = "Model Eklendi";
        public static string BrandDeleted = "Model Silindi";
        public static string BrandsListed = "Modeller Listelendi";
        public static string BrandListed = "Model Listelendi";
        public static string BrandUpdated = "Model Güncellendi";
    }
}
