using FİNAL1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FİNAL1.Controllers
{
    public class SystemController : Controller
    {
        //Personel modelinden liste üretip kullanıcı ve user ekledim
        private static List<SystemClass> _personel = new List<SystemClass> {
  new SystemClass{Id=1,KulaniciAd="UgurErkan",sifre="Ugur.123",yetki=1},
  new SystemClass{Id=2,KulaniciAd="AyseEldem",sifre="Ayse.2015",yetki=1},
  new SystemClass{Id=3,KulaniciAd="AliBircan",sifre="AliHocam1",yetki=1},
  new SystemClass{Id=3,KulaniciAd="MustafaTuncer",sifre="Mustafa.1312",yetki=2},
  new SystemClass{Id=3,KulaniciAd="KuyucuMustafa",sifre="kuyucu.2000",yetki=2},
  new SystemClass{Id=3,KulaniciAd="YeşimGezici",sifre="GeziCi.Tan",yetki=2},
  
  };
        private readonly ILogger<SystemController> _logger;

        public SystemController(ILogger<SystemController> logger)
        {
            _logger = logger;
        }
        //View geri döndürüldü form get edildi
        public IActionResult Index()
        {
            return View();
        }
        //Postta çalışacak action yazdım
        [HttpPost]
        public IActionResult Index(string KullaniciAdi,string sifre)
        {    

            // oluşturulan liste dolaşılıp kullanıcı ad ve şifre kontrol edildi
            foreach (var eleman in _personel) {
                if (eleman.KulaniciAd==KullaniciAdi)
                {
                    if (eleman.sifre == sifre)
                    {
                        if (eleman.yetki== 1)
                        {
                            // yetkisi admin olanlar 1 olarak belirtilip admin sayfasına yönlendirildi
                            return RedirectToAction("Index", "Admin");
                        }
                        else if (eleman.yetki == 2)
                        {
                            // yetkisi Kullanıcı olanlar 2 olarak belirtilip kontrolü sağlandı ve user sayfasına yönlendrildi
                            return RedirectToAction("Index", "User");
                        }
                    }
                }
            
            }
            //eğer kullanıcı adı veya şifre yanlışsa geri form yeniden dönderildi
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}
