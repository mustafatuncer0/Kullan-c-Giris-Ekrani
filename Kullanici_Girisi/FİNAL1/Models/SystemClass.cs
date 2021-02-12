using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FİNAL1.Models
{
    public class SystemClass
    {
        //data base gibi veri tutmayı sağlaması için class yapısı oluşturuldu
        public int Id { get; set; } //Id özelliği oluşturuldu ve get set fonksiyonları tanımlandı
        public string KulaniciAd { get; set; } //Kullanıcı Adı özelliği oluşturuldu ve get set fonksiyonları tanımlandı

        public string sifre { get; set; }//sifre özelliği oluşturuldu ve get set fonksiyonları tanımlandı

        public int yetki {get; set; }//yetki özelliği oluşturuldu ve get set fonksiyonları tanımlandı
    }
}
