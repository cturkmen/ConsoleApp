using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace StringKullanımı
{
    class Program
    {
        static void Main(string[] args)
        {
            // string: metinsel ifadelerin kullanıldığı veri tipi

            //string ad = "Nevzat";
            //string soyad = "Akagündüz";

            //string adSoyad = ad + soyad;
            //Console.WriteLine(adSoyad);

            //string adSoyad2 = ad + " " + soyad;
            //Console.WriteLine(adSoyad2);

            //string adSoyad3 = ad + "\n" + soyad; //   \n kelimeyi bir alt satırdan başlatarak yazar.
            //Console.WriteLine(adSoyad3);

            ////  + operatoru string değişkeleri birleştirerek yazar.

            //Console.WriteLine("hoşgeldin {0} ", adSoyad2);

            //string s1 = "12";
            //string s2 = "34";
            ////string yeniSayi;
            ////yeniSayi = s1 + s2;
            ////Console.WriteLine(yeniSayi);
            //Console.WriteLine("Sayi={0}", s1 + s2);


            //int a = 12;
            //int b = 34;
            //Console.WriteLine("Sayi ={0}",a+b);

            #region Dışarıdan değer alıp yazdırma
            /*
            Console.Write("adınızı giriniz : ");
            //Console.WriteLine("adinizi giriniz :");
            string ad = Console.ReadLine();
            Console.WriteLine("hoşgeldin {0}",ad);

            Console.WriteLine("yaşınızı giriniz : ");
            //int yas;
            //yas = int.Parse(Console.ReadLine());
            int yas = int.Parse(Console.ReadLine());
            Console.WriteLine("Yaşınız : {0}",yas);
            */
            //Console.ReadLine() sadece string veri tipindeki değişkenleri okuyabildiği için başka veri tipinden değişken tanımlandığında string veri tipine çevirmek zorundayız.

            // .parse komutu herhangi bir veri tipini string veri tipine dönüştürür.

            //double yas2;
            //yas2 = double.Parse(Console.ReadLine());
            #endregion

            #region Basit hesap makinesi

            //Console.Write("1.sayiyi giriniz: ");
            //int sayi1 = int.Parse(Console.ReadLine());

            //Console.Write("2.sayiyi giriniz: ");
            //int sayi2 = int.Parse(Console.ReadLine());

            ////toplama
            //int toplam = sayi1 + sayi2;
            ////int toplam;
            ////toplam = sayi1 + sayi2;

            //Console.WriteLine("{0} + {1} = {2}", sayi1, sayi2, toplam);

            ////çıkarma
            //int cikarma = sayi1 - sayi2;
            //Console.WriteLine("{0} - {1} = {2}", sayi1, sayi2, cikarma);

            ////çarpma
            //int carpma = sayi1 * sayi2;
            //Console.WriteLine("{0} x {1} ={2}", sayi1, sayi2, carpma);

            ////bölme
            //int bolme = sayi1 / sayi2;
            //Console.WriteLine("{0} / {1} ={2}", sayi1, sayi2, bolme);

            ////ortalama
            //int ortalama = (sayi2 + sayi1) / 2;// işlem önceliğine dikkat
            //Console.WriteLine("{0} sayısı ile {1} sayısının ortalaması = {2}", sayi1, sayi2, ortalama);

            #endregion

            #region Çemberin Çevresi ve alanı

            //double pi = 3.14;
            //Console.WriteLine("yarıçapı giriniz: ");
            //double yarıcap = double.Parse(Console.ReadLine());
            //double cevre = 2 * yarıcap * pi;
            //Console.WriteLine("çemberin çevresi: {0}", cevre);

            ////alan hesaplayalım

            //double alan = yarıcap * yarıcap * pi;
            //Console.WriteLine("dairenin alanı : {0}", alan);


            #endregion

            #region karenin çevresi ve alanı

            //Console.WriteLine("kenarı giriniz : ");
            //double kenar = double.Parse(Console.ReadLine());

            ////double cevre = 4 * kenar;
            ////Console.WriteLine("karenin çevresi : {0} ", cevre);
            //Console.WriteLine("karenin çevresi :{0}", kenar * 4);

            ////double alan = kenar * kenar;
            ////Console.WriteLine("karenin alanı :{0}", alan);
            //Console.WriteLine("karenin alanı :{0}", kenar * kenar);
            #endregion

            #region dikdörtgenin alan ve çevresi

            //int kisaKenar, uzunKenar, Alan, Cevre;

            //Console.WriteLine("kisa kenarı giriniz: ");
            //kisaKenar = int.Parse(Console.ReadLine());

            //Console.WriteLine("uzun kenarı giriniz : ");
            //uzunKenar = int.Parse(Console.ReadLine());

            //Cevre = 2 * (kisaKenar + uzunKenar);
            //Alan = kisaKenar * uzunKenar;

            //Console.WriteLine("dikdörtgenin alanı: {0}", Alan);
            //Console.WriteLine("dikdörtgenin çevresi : {0}", Cevre);
            #endregion

            #region 2 açısı girilen üçgenin 3.açısını bulma

            //int aci1, aci2;
            //Console.Write("1.açısını giriniz : ");
            //aci1 = int.Parse(Console.ReadLine());

            //Console.Write("2.açısını giriniz : ");
            //aci2 = int.Parse(Console.ReadLine());

            //int aci3 = 180 - (aci1 + aci2);
            //Console.Write("üçgenin 3. açısı : {0} ", aci3);
            #endregion

            #region faiz hesabı

            //double anapara, yil, faiz = 6;
            //Console.WriteLine("yatırılan parayı giriniz: ");
            //anapara = double.Parse(Console.ReadLine());

            //Console.WriteLine("kaç yıl : ");
            //yil = double.Parse(Console.ReadLine());
            //double hesapTutari = anapara * faiz * yil / 100;
            //double toplamPara = hesapTutari + anapara;

            //Console.WriteLine("{0} yıl sonunda {1} tl yatırılan paranın faiz tutarı {2} tl , faizle birlikte elindeki para {3} tl olmuştur", yil, anapara, hesapTutari, toplamPara);


            #endregion

            #region doğum yılına göre kaç yaşında olduğunu bulan uygulama

           // Console.WriteLine("doğum yilini giriniz : ");
           // int tarih = int.Parse(Console.ReadLine());
           //// int yas = 2014 - tarih;
           ////Console.WriteLine(yas);

           // int yas = DateTime.Now.Year - tarih;
           // Console.WriteLine(yas);



            #endregion


            












        }
    }
}
