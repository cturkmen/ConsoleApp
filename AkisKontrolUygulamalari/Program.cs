using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AkisKontrolUygulamalari
{
    class Program
    {
        static void Main(string[] args)
        {
            #region dikdörtgenin alanını hesapla. kullanıcı kısa kenarı uzun kenardan büyük girmesin

            //Console.WriteLine("uzun kenarı giriniz : ");
            //int uzunKenar = int.Parse(Console.ReadLine());
            //Console.WriteLine("kısa kenarı giriniz : ");
            //int kisaKenar = int.Parse(Console.ReadLine());

            //if (uzunKenar > kisaKenar)
            //{
            //    Console.WriteLine("Alan = {0} ", kisaKenar * uzunKenar);
            //}
            //else
            //{
            //    Console.WriteLine("uzun kenar kisa kenardan küçük olamaz");
            //}

            #endregion

            #region girilen gün adına göre haftanın kaçıncı günü olduğunu yazdıran uygulama

            //Console.WriteLine("gün adını giriniz :");
            //string gun = Console.ReadLine();

            //switch (gun)
            //{
            //    case "pazartesi": // string ifadelerde " " içinde nasıl yazıldıysa birebir kullanılmalı
            //        Console.WriteLine("{0} haftanın 1. günü", gun);
            //        break;
            //    case "salı":
            //        Console.WriteLine("{0} haftanın 2. günü", gun);
            //        break;
            //    case "çarşamba":
            //        Console.WriteLine("{0} haftanın 3. günü", gun);
            //        break;

            //}



            /*
            if (gun=="pazartesi")
            {
                Console.WriteLine("{0} haftanın 1. günü",gun);
            }
            else if(gun=="salı")
            {
                Console.WriteLine("{0} haftanın 2. günü", gun);
            }
            else if(gun=="Çarşamba")
            {
                Console.WriteLine("{0} haftanın 3. günü", gun);
            }
            else if (gun == "Perşembe")
            {
                Console.WriteLine("{0} haftanın 4. günü", gun);
            }
            else if (gun == "Cuma")
            {
                Console.WriteLine("{0} haftanın 5. günü", gun);
            }
            else if (gun == "Cumartesi")
            {
                Console.WriteLine("{0} haftanın 6. günü", gun);
            }
            else if (gun == "Pazar")
            {
                Console.WriteLine("{0} haftanın 7. günü", gun);
            }
            */

            #endregion

            #region reşit olma durumu

            //Console.WriteLine("Doğum tarihinizi giriniz : ");
            //int tarih = int.Parse(Console.ReadLine());

            //int yas = DateTime.Now.Year - tarih;

            //if (yas>=18)
            //{
            //    //Console.WriteLine("Yaşınız: {0}",yas);
            //    //Console.WriteLine("Reşitsin");
            //    Console.WriteLine("Yaşınız :{0} \n Reşitsin",yas);
            //}
            //else
            //{
            //    Console.WriteLine("Yaşınız: {0}", yas);
            //    Console.WriteLine("Reşit değilsin");
            //}


            #endregion

            #region negatif pozitif nötr

            //Console.WriteLine("Sayi giriniz: ");
            //int sayi = int.Parse(Console.ReadLine());
            /*
                        if (sayi > 0)
                        {
                            Console.WriteLine("{0} sayisi pozitiftir", sayi);
                        }
                        else if (sayi < 0)
                        {
                            Console.WriteLine("{0} sayisi negatiftir", sayi);
                        }
                        else
                        {
                            Console.WriteLine("sayi sıfırdır");
                        }
             */


            /*
            switch (sayi)
            {
                case 0:
                    Console.WriteLine("Sayi sıfırdır");
                    break;
                default: // sayi 0 dışında herhangi bir değerse
                    if (sayi<0)
                    {
                        Console.WriteLine("{0} sayisi negatiftir",sayi);
                    }
                    else
                    {
                        Console.WriteLine("{0} sayisi pozitiftir",sayi);
                    }
                    break;
            }
             * */
            #endregion

            #region tek çift

            //Console.WriteLine("sayi giriniz : ");
            //int sayi = int.Parse(Console.ReadLine());

            //if (sayi % 2 == 0)
            //{
            //    Console.WriteLine("{0} sayisi çifttir", sayi);
            //}
            //else
            //{
            //    Console.WriteLine("{0} sayisi tektir", sayi);
            //}

            /*
            bool a = sayi%2 == 0;
            switch (a)
            {
                case true:
                    Console.WriteLine("sayı çift");
                    break;
                case false:
                    Console.WriteLine("sayı tek");
                    break;
            }
             */

            #endregion

            #region vize final
            /*
            Console.WriteLine("vize notunuzu giriniz: ");
            int vize = int.Parse(Console.ReadLine());
            Console.WriteLine("final notunuzu giriniz :");
            int final = int.Parse(Console.ReadLine());

            double ort = (vize*0.3) + (final*0.7);
            Console.WriteLine("ortalamanız : {0}",ort);

            if (ort >=50)
            {
                Console.WriteLine("geçtiniz");
            }
            else
            {
                Console.WriteLine("kaldınız");
            }
             */

            #endregion

            #region kullanıcı adı: admin ve şifre:1234 girildiğinde giriş başarılı, farklı girilirse giriş başarısız yazsın

            //Console.WriteLine("kullanıcı adını giriniz: ");
            //string kAdi = Console.ReadLine();
            //Console.WriteLine("şifrenizi giriniz : ");
            //int sifre = int.Parse(Console.ReadLine());

            //bool user = (kAdi == "admin" && sifre == 1234);

            //if (user == true)
            //{
            //    Console.WriteLine("giriş başarılı");
            //}
            //else
            //{
            //    Console.WriteLine("giriş hatalı");
            //}


            //if (kAdi=="admin" && sifre==1234)
            //{
            //    Console.WriteLine("giriş başarılı");
            //}
            //else
            //{
            //    Console.WriteLine("giriş başarısız");
            //}



            #endregion

            #region  klavyeden kenarları girilen üçgenin çeşidini bulunuz.eşkenar , ikizkenar , çeşitkenar

            //Console.WriteLine("1.kenari giriniz : ");
            //int k1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("2.kenarı giriniz: ");
            //int k2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("3.kenarı giriniz : ");
            //int k3 = int.Parse(Console.ReadLine());

            //if (k1==k2 && k2==k3)
            //{
            //    Console.WriteLine("eşkenar üçgendir");
            //}
            //else if (k1!=k2 && k2!=k3 && k1!=k3 )
            //{
            //    Console.WriteLine("çeşitkenar üçgen");
            //}
            //else
            //{
            //    Console.WriteLine("ikizkenar üçgendir");
            //}





            #endregion

            #region mağazada alışveriş tutarına göre indirim yapılacak.               200 tl->%10,  200-400 ->%15, 400 ve üzeri ->%20

            //Console.WriteLine("alışveriş tutarınızı giriniz : ");
            //int tutar = int.Parse(Console.ReadLine());
            //double indirim=0;

            //if (tutar == 200)
            //{
            //    indirim = tutar * 0.1;
            //    //Console.WriteLine("{0} tl lik alışverişinizden {1} tl indirim kazandınız. Toplam ödenecek tutar: {2} tl dir", tutar, indirim, tutar - indirim);
            //}
            //else if (tutar > 200 && tutar < 400)
            //{
            //    indirim = tutar * 0.15;
            //    // Console.WriteLine("{0} tl lik alışverişinizden {1} tl indirim kazandınız. Toplam ödenecek tutar: {2} tl dir", tutar, indirim, tutar - indirim);
            //}
            //else if (tutar >= 400)
            //{
            //    indirim = tutar * 0.2;
            //    // Console.WriteLine("{0} tl lik alışverişinizden {1} tl indirim kazandınız. Toplam ödenecek tutar: {2} tl dir", tutar, indirim, tutar - indirim);
            //}
            //else
            //{
            //    Console.WriteLine("200 tl'nin altındaki alışverişlerde herhangi bir indirim yoktur.");
            //}
            //Console.WriteLine("{0} tl lik alışverişinizden {1} tl indirim kazandınız. Toplam ödenecek tutar: {2} tl dir", tutar, indirim, tutar - indirim);
            #endregion

            #region kaç basamaklı

            //Console.WriteLine("sayi giriniz : ");
            //int sayi = int.Parse(Console.ReadLine());

            //if (sayi >= 0 && sayi < 10)
            //{
            //    Console.WriteLine("sayi tek basamaklidir");
            //}
            //if (sayi >= 10 && sayi <= 99)
            //{
            //    Console.WriteLine("sayi 2 basamaklıdır");
            //}
            //if (sayi >= 100 && sayi < 999)
            //{
            //    Console.WriteLine("sayi 3 basamaklıdır.");
            //}
            //if (sayi >= 1000 && sayi <= 9999)
            //{
            //    Console.WriteLine("sayi 4 basamaklıdır");
            //}
            //if (sayi >= 10000)
            //{
            //    Console.WriteLine("çok basamaklıdır");
            //}

            #endregion

            #region mat kitabı 150 tl. kullanıcı mat kitabı girerse %10 indirim yapılacak. diğer kitap turleri için herhangi bir indirim yok

            //Console.WriteLine("kitap türü giriniz:  ");
            //string kitap = Console.ReadLine();
            //int fiyat = 150;

            //if (kitap == "matematik")
            //{
            //    Console.WriteLine("indirim: {0}", fiyat * 0.1);

            //}
            //else
            //{
            //    Console.WriteLine("{0} kitabına türüne indirim yoktur", kitap);
            //}


            #endregion

            #region bir işyeri çalışanlarına maaşları dışında prim vermektedir. prim hesabı aşagıdaki tabloya göre yapılıyor. kullanıcıya ürettiği ürün miktarını sorup alacagı toplam ucreti hesaplayacak. 1-10 parça : parça başı 5 tl, 11-25 parça : parça başı 6 tl,    26-40 parça :  parça başı 8 tl, 40-100 parça:  parça başı 10 tl , sabit maaş:1000tl

            Console.WriteLine("kaç parça üretim yaptın? ");
            int parca = int.Parse(Console.ReadLine());

            int prim = 0, maas = 1000;
            if (parca >= 1 && parca <= 10)
            {
                prim = parca * 5;
            }
            else if (parca <= 11 && parca >= 25)
            {
                prim = parca * 6;
            }
            else if (parca <= 26 && parca <= 40)
            {
                prim = parca * 8;
            }
            else if (parca <= 41 && parca >= 100)
            {
                prim = parca * 10;
            }
            Console.WriteLine("alacağınız toplam maas= {0}", maas + prim);



            #endregion
        }
    }
}
