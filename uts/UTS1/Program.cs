using System;

namespace UTS1nameTag
{
    class program
    {
        static void Main(String[] args)
        {
            string nama;
            
            Console.Clear();
            Console.WriteLine("Nama :   ");
            var Nama = Console.ReadLine();
            Console.WriteLine("NIM :    ");
            var NIM = Console.ReadLine();
            Console.WriteLine("Konsentrasi :");
            var Konsentrasi = Console.ReadLine();
            Console.WriteLine("|**********************|");
            Console.WriteLine("|Nama:{0,17}|", Nama);
            Console.WriteLine("|{0,22}|", NIM);
            Console.WriteLine("|----------------------|");
            Console.WriteLine("|{0,22}|", Konsentrasi);
            Console.WriteLine("|**********************|");
        }
    }
}
