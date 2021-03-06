﻿using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages  //static yapmamız sebebi bunu sürekli newlemek durumunda kalmamak için ekleriz.
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductUpdated = "Ürün Güncellendi";
        public static string ProductCountOfCategoryError = "En Fazla 10 Ürün Eklenebilir!";
        public static string ProductWithTheSameNameCannotBeAdded = "Aynı isimli Ürün Eklenemez!";
        public static string CategoryLimitExceded = " Kategori Limiti Aşıldığı için Yeni Ürün Eklenemez!";
        public static string AuthorizationDenied = "Yetkilendirme Reddedildi";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Şifre Hatası";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Geçerli Bir Kullanıcı Mevcut";
        public static string AccessTokenCreated = "Erişim Anahtarı Oluşturuldu";
        public static string UserRegistered = "Kullanıcı Kayıtlı";
    }
}
