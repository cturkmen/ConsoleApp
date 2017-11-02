using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Aritmetik Operatorler
             * Karşılaştırma Operatorleri
             * Mantıksal Operatorler
             * Atama ve İşlemli Atama Operatorleri
             */

            // #region  #endregion alan oluşturmaya yarar. Kodların daha düzenli görünmesini sağlar.

            #region Aritmetik Operatorler : +, - ,* ,/, % ,++, --

            //float a = 21, b = 10, c;

            //c = a + b;// asıl işlemin yapıldığı yer
            //Console.WriteLine("{0} + {1} = {2}", a, b, c);// yazıyı formatlama kısmı

            //c = a - b;
            //Console.WriteLine("{0} - {1} = {2}", a, b, c);

            //c = a * b;
            //Console.WriteLine("{0} x {1} = {2}", a, b, c);

            //c = a / b;
            //Console.WriteLine("{0} / {1} = {2}", a, b, c);

            //c = a % b;
            //Console.WriteLine("{0} mod {1} = {2}", a, b, c);

            ////c = a++;
            ////c = ++a;
            //c = a + 1;
            //Console.WriteLine(c);
            //Console.WriteLine(a);

            //c = b--;
            //Console.WriteLine(c);
            //Console.WriteLine(b);

            #endregion

            #region örnek

            //int a = 10;
            //int b = 20;
            //int c = 30;
            //int d = 40;
            //float f = 5.6f;
            //int x, y, z;

            //a++; // a+1
            //++b; //b+1
            //c--; //c-1
            //--d;
            //f++;

            //x = a++;
            //y = ++a;
            //z = ++a;

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.WriteLine(f);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            #endregion


            #region karşılaştırma operatorleri : ==, !=, < , >, >= ,<=

            //bool b1 = 60 < 50;
            //bool b2 = 50 < 60;
            //bool b3 = 60 == 60;
            //bool b4 = 60 != 50;

            //Console.WriteLine(b1);
            //Console.WriteLine(b2);
            //Console.WriteLine(b3);
            //Console.WriteLine(b4);

            #endregion


            #region mantıksal operatorler :  && and, || veya, ! not

            //&& and: 
            /*true true true
              *true false false
              *false true false
              *false false false
              */

            //bool a = (35 < 10) && (35 == 50);  //false && false  = false     bool a=false
            //bool a1 = 35 > 10 && 35 == 35; // true && true = true


            // || or :
            /*true true true
             * true false true
             * false true true
             * false false false
             */

            //bool c = 35 < 10 || 10 == 50; //  false || false = false
            //bool c1 = 35 > 10 || 10 != 50; //true || true =true

            // ! not: işlemin tam tersini yapar

            //bool d = !(35 > 10); // !(true) = false
            //bool d1 = !(10==35) // !(false) = true

            #endregion

            #region Atama ve İşlemli Atama Operatorleri : =, +=, -=, *= ,/= , %=
            // = 
            int a = 20;
            int c;
            c = a; // a'nın değerini c değişkenine atamak.
            Console.WriteLine("c'nin atamadan sonraki değeri : {0}", c);


            // +=

            c += a; //c = c + a; c ile a yı topla c'nin yeni değerini bul
            Console.WriteLine("c'nin toplamadan sonraki değeri : {0}", c);

            // -=

            c -= a; // c=c-a;
            Console.WriteLine("c'nin çıkarmadan sonraki değeri :{0}", c);

            // *=

            c *= a; // c=c*a;
            Console.WriteLine("c'nin çarpmadan sonraki değeri: {0}", c);

            // /=

            c /= a;// c=c/a;
            Console.WriteLine("c'nin bölmeden sonraki değeri :{0}", c);

            // %=

            c %= a;// c=c%a;
            Console.WriteLine("c'nin mod aldıktan sonraki değeri: {0}",c);

            c += 1; // c=c+1;
            Console.WriteLine("c'nin 1 artırdıktan sonraki değeri :{0}",c);

            c += 3; // c=c+3;
            Console.WriteLine("c'nin 3 artırdıktan sonraki değeri :{0}", c);

            a += 1; // a=a+1;
            Console.WriteLine("a'nın 1 artırdıktan sonraki değeri :{0}", a);

            a %= c; // a=a%c;
            Console.WriteLine("a'nın mod aldıktan sonraki değeri :{0}", a);




            #endregion



        }
    }
}
