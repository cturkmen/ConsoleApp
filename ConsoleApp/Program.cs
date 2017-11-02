using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        private static void Main(string[] args)
        {
            #region

            //Main işlevi programın başladığı yerdir.

            //ilk açılan parantez en son kapatılır.

            //tek satırlı açıklama 

            /*birden
             * fazla satırlı
             * açıklama
             */

            //case sensitive: büyük küçük harf duyarlı bir dildir
            //Ad ile ad aynı şeyler değil.
            //açıklama satırına alırken kısayol-> ctrl +k + c
            //açıklama satırından çıkarırken kısayol->ctrl +k +u
            // auto format -> ctrl + k + d
            /*EN ÖNEMLİ:
             *    YAZACAĞIMIZ BÜTÜN KODLAR  ;  İLE   BİTER
             */

            #endregion

            Console.Write("merhaba dünya");//ekrana tırnak içindeki ifadeleri yazar.
            //Console.Write(); ile bir sonraki yazacağımız ifade yanından devam eder.
           // Console.WriteLine(); // bir sonraki ifade alt satırdan başlayarak yazılır.


            Console.WriteLine("merhaba dünya1");

            // Debug işleminde F5 programı çalıştırır,hataları tarar ve programı kapatır
            // debug işlemin,i ctrl+ F5 ile çalıştırırsak console ekranı ekranda kalır ve kapatmamızı bekler


            Console.ReadLine();// console ekranında enter tuşuna basılmasını bekler.
            Console.ReadKey(); // console ekranında herhangi bir tuşa basılmasını bekler.

        }
    }
}
