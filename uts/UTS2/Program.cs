using System;

namespace UTS2tebakAngka
{
    class program
    {
        static void Main(String[] args)
        {
            Console.Clear();
            Random random = new Random();
            int Random = random.Next(1, 100);
            bool tebak = false;
            int tebakan = 0;
            

            while (!tebak)
            {
                Console.Write("Tebak angka antara 1 - 100 : ");
                int Inisialisai = Convert.ToInt32(Console.ReadLine());
                tebakan += 1;
                if(Inisialisai == Random)
                {
                    Console.WriteLine("Anda benar!");
                    Console.WriteLine("Bye...");
                    break;
                }
                else if(Inisialisai <Random)
                {
                    Console.WriteLine("Salah. Nilai terlalu rendah.");
                }
                else if(Inisialisai>Random)
                {
                    Console.WriteLine("Salah. Nilai terlalu tinggi.");
                }
                
            }
           
        } 
    }
}