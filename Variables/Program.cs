using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b1;        // 1byte    -128/127    
            sbyte b2;       // 1byte    0/255

            short s1;       // 2byte    -32.768/32.767
            ushort s2;      // 2byte    0/65.535

            int i1;         // 4byte    -2.147.483.648/2.147.483.647
            uint i2;        // 4byte    0/4.294.967.295

            long l1;        // 8byte    -9.223.372.036.854.775.808/9.223.372.036.854.775.807
            ulong l2;       // 8byte    0/18.446.744.073.709.551.615

            float f1;       // 4byte
            double d1;      // 8byte
            decimal d2;     // 16byte

            char c1;        // 2byte
            string str;     // sınırsız

            bool b3;        // 1byte    true/false
            object o1;      // hertürden veriyi tutabilir.


            DateTime dt1 = DateTime.Now;
            Console.WriteLine(dt1);
            

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
            Console.ReadLine();

        }
    }
}
