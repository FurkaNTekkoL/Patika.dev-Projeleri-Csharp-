using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atama ve İşlemli atama

            Console.WriteLine("*** Atama operatörleri ***");

            int x = 3;
            int y = 3;
            y = y + 2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            bool isSuccess = true;
            bool isCompleted = false;

            // Mantıksal operatörler

            Console.WriteLine("*** Mantıksal operatörler ***");


            // && : ve
            // || : veya
            // !  : değil

            if (isSuccess && isCompleted)
            {
                Console.WriteLine("Perfect!");
            }

            if (isSuccess || isCompleted)
            {
                Console.WriteLine("Great!");
            }

            if (isSuccess && !isCompleted)
            {
                Console.WriteLine("Fine!");
            }

            // İlişkisel Operatörler

            // <  : küçüktür
            // >  : büyüktür
            // <= : küçük eşittir
            // >= : büyük eşittir
            // == : eşittir
            // != : eşit değildir

            Console.WriteLine("*** İlişkisel operatörler ***");


            int a = 3;
            int b = 4;
            bool sonuc = a < b;

            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);


            // Aritmetik Operatörler

            // / : bölme
            // * : çarpma
            // + : toplama
            // - : çıkarma
            // % : mod alma (kalan değerini verir)

            Console.WriteLine("*** Aritmetik Operatörler ***");

            int sayi1 = 10;
            int sayi2 = 5;

            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1++;
            Console.WriteLine(sayi1);

            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2);

            Console.ReadLine();
        }
    }
}
