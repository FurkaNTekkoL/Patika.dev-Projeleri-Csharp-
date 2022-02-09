using System;

namespace Project1__Console_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen adınızı girininiz:");
            string name = Console.ReadLine();
            Console.WriteLine("Lütfen soyadınızı girininiz:");
            string surname = Console.ReadLine();
            Console.WriteLine("Lütfen yaşınızı:");
            string age = Console.ReadLine();
            Console.WriteLine("Kişi Bilgileri:");
            Console.WriteLine("İsim: " + name);
            Console.WriteLine("Soyisim: " + surname);
            Console.WriteLine("Yaş: " + age);
            Console.ReadLine();
        }
    }
}
