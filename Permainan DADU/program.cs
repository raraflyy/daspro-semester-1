using System;

namespace Dadu
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            GamePlay();
            Outro();
        }

        static void Intro() 
        {
            Console.WriteLine("DADU\n");
            Console.WriteLine("Selamat datang dalam permainan DADU");
            Console.WriteLine("Pada permainan Dadu kali ini player akan berlawanan dengan komputer");
            Console.WriteLine("Permainan terdiri dari 5 Ronde");
            Console.WriteLine("Masing masing pemain memiliki kesempatan melempar dadu satu kali setiap rondenya");
            Console.WriteLine("Setelah permainan selesai");
            Console.WriteLine("Pemain yang memperoleh poin terbanyak akan memenangkan permainan");
        }
        static void GamePlay() 
        {
            int daduKomputer;
            int daduPlayer;

            int jumlahRonde = 0;
            int pointKomputer = 0; 
            int pointPlayer = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\nTekan tombol apa saja untuk memulai...\n");
                Console.ReadKey();

                jumlahRonde++;
                Console.WriteLine("Ronde " + jumlahRonde);
                daduKomputer = numbGen();
                Console.WriteLine("Komputer melempar dadu dan memperoleh angka " + daduKomputer + ".");
                Console.ReadKey();
                daduPlayer = numbGen();
                Console.WriteLine("Player melempar dadu dan memperoleh angka " + daduPlayer + ".");

                if (daduPlayer > daduKomputer)
                {
                    pointPlayer++;
                    Console.WriteLine("Player memenangkan ronde ini!");
                } else if (daduKomputer > daduPlayer) {
                    pointKomputer++;
                    Console.WriteLine("Komputer memenangkan ronde ini!");
                } else {
                    Console.WriteLine("Ronde ini seri!");
                }

                Console.WriteLine("Poin Player saat ini: " + pointPlayer + " || Poin Komputer saat ini: " + pointKomputer);
                Console.WriteLine("----------------------------------------------------------------------------------");
                Console.ReadKey();
                Console.Clear();
            }

            if (pointPlayer > pointKomputer)
            {
                Console.WriteLine("Permainan dimenangkan oleh Player!");
            } else if (pointKomputer > pointPlayer) {
                Console.WriteLine("Permainan dimenangkan oleh Komputer!");
            } else {
                Console.WriteLine("Permainan berakhir seri...");
            }
            Console.ReadKey();
        }
        static void Outro() 
        {
            Console.WriteLine("Permainan ini dibuat oleh");
            Console.WriteLine("Nama  : Rafly Wirangga");
            Console.WriteLine("Prodi : Teknik Informatika");
            Console.WriteLine("NIM   : 2207112577");
            Console.ReadKey();
        }
        static int numbGen() 
        {
            Random numbGen = new Random();
            int numb = numbGen.Next(1, 7);
            return numb;
        }
    }
}