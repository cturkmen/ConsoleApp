using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace AkisKontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Koşul ifadeleri:
             * 1. if else
             * 2. switch-case
             */

            #region if else deyimi
            /*
            if (koşul)
            {
              deyim1  
            }
            else
            {
                deyim2
            }
             */
            //program if deyimine gelince if parantezindeki koşul çalıştırılır. eğer doğruysa deyim1, yanlışsa deyim 2 çalıştırılır

            //int a = 5;
            //int b = 7;

            //if (a < b)
            //{
            //    a++;
            //    Console.WriteLine(a);
            //}
            //else
            //{
            //    b++;
            //    Console.WriteLine(b);
            //}


            //// çoklu koşul seçme

            //int not;
            //Console.WriteLine("notunuzu giriniz : ");
            //not = int.Parse(Console.ReadLine());

            //if (not > 90)
            //{
            //    Console.WriteLine("Notunuz : A");
            //}
            //else if (not > 80)
            //{
            //    Console.WriteLine("Notunuz : B");
            //}
            //else if (not > 70)
            //{
            //    Console.WriteLine("Notunuz : C");
            //}
            //else if (not >= 50)
            //    Console.WriteLine("Notunuz :D");
            //else
            //    Console.WriteLine("Dersi geçemediniz");

            // içiçe if
            /*
            if (koşul1)
            {
                if (koşul2)
                {
                    deyim1;
                }
                else
                {
                    deyim2
                }
            }
            else
            {
                deyim3;
            }
             */



            //Console.Write("1.sayiyi giriniz : ");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.Write("2.sayiyi giriniz : ");
            //int sayi2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("toplama----->t");
            //Console.WriteLine("Çıkarma----->c");
            //Console.WriteLine("Çarpma------>x");
            //Console.WriteLine("Bölme------>b");
            //Console.Write("Yapmak istediğiniz işlemi seçiniz: ");
            //char islem = char.Parse(Console.ReadLine());

            //if (islem == 't')
            //{
            //    Console.WriteLine("Sonuç ={0}", sayi1 + sayi2);
            //}
            //else if (islem == 'c')
            //{
            //    Console.WriteLine("Sonuc={0}", sayi1 - sayi2);
            //}
            //else if (islem == 'x')
            //{
            //    Console.WriteLine("sonuc={0}", sayi1 * sayi2);
            //}
            //else if (islem == 'b')
            //{
            //    if (sayi2 != 0)
            //    {
            //        float Sonuc = (float)sayi1 / (float)sayi2;
            //        Console.WriteLine("Sonuc={0}", Sonuc);
            //    }
            //    else
            //    {
            //        Console.WriteLine("bölen 0 olamaz");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış işlem seçtiniz");
            //}
            #endregion

            #region switch case
            //genellikle kompleks if else bloklarının yerine tercih edilir.
            /*
             * switch(ifade)
             * {
             * case sabit1:
             * deyim1;
             * break;
             * 
             * case sabit2:
             * deyim2;
             * break;
             * 
             * default:
             * deyim3;
             * break;
             *
             * }
             */
            //program çalışırken;
            // 1. switch içindeki ifade hesaplanır
            //2. programın akışı hesaplanan  ifade ile aynı case sabitinin bulunduğu satıra gelir
            //3. eğer herhangi bir case sabiti durumu karşılamıyorsa default 'un bulunduğu satıra gelir ve burdan devam eder.

            //kurallar:
            /* 
             * 1. switch blokları içinde yer alan case'ler aynı ada sahip olamazlar
             * 2.case'in yanındaki ifadeler SABİT olmak zorundadır. 
             * 3. default bulunmak zorunda değildir.
             * 
             */

            //Console.WriteLine("1.sayıyı giriniz : ");
            //int sayi1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("2.sayıyı giriniz : ");
            //int sayi2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("toplama----->t");
            //Console.WriteLine("Çıkarma----->c");
            //Console.WriteLine("Çarpma------>x");
            //Console.WriteLine("Bölme------>b");

            //Console.WriteLine("yapmak istediğiniz işlemi seçiniz : ");
            //char islem = char.Parse(Console.ReadLine());

            //switch (islem)
            //{
            //    case 't':
            //        Console.WriteLine("Sonuç : {0}", sayi1 + sayi2);
            //        break;
            //    case 'c':
            //        Console.WriteLine("Sonuç: {0}", sayi1 - sayi2);
            //        break;
            //    case 'x':
            //        Console.WriteLine("Sonuç :{0}", sayi1 * sayi2);
            //        break;
            //    case 'b':
            //        switch (sayi2)
            //        {
            //            case 0:
            //                Console.WriteLine("Bölen 0 olamaz");
            //                break;
            //            default:
            //                Console.WriteLine("Sonuç:{0}", sayi1 / sayi2);
            //                break;
            //        }

            //        break;

            //}



            #endregion

            #region atlama deyimleri: break, continue, go to, return

            //break: program break satırına gelince çıkmayı sağlar.
           // continue: ait bloktan çıkmayı sağlar.
            //goto : döngülerde kullanılır.  programın belli bir satırında diğerine atlamak için kullanılır

            /*
            sayisor:
            Console.WriteLine("sayi giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            if (sayi!=1)
            {
                goto sayisor;
            }
             */

            //return:metotların sonlandırılmasında kullanılır.

            #endregion
        }
    }
}
