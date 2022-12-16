using System;

namespace UTS3pinjaman
{
    class Program
    {
        static void Main(string[] args)
        {
            int lamaPeminjaman;
            int totalDenda;
            int lamaPeminjaman1;
            int lamaPeminjaman2;
            int totalDenda1;
            int totalDenda2;
            int lamaPeminjaman3;
            
            Console.Write("Input jumlah hari peminjman : ");
            lamaPeminjaman = Convert.ToInt32(Console.ReadLine());

            //if1
            lamaPeminjaman1 = lamaPeminjaman - 5;
            totalDenda = 10000;

            //if2
            lamaPeminjaman2 = lamaPeminjaman - 10;
            totalDenda1 = 20000;
            int Denda1 = 50000;
            int denda2 = totalDenda1 * lamaPeminjaman2;
            denda2 = denda2 + Denda1;

            //if3
            lamaPeminjaman3 = lamaPeminjaman - 30;
            totalDenda2 = 30000;
            int Denda2 = 40000;
            int denda3 = totalDenda2 * lamaPeminjaman3;
            denda3 = denda3 + Denda1 + Denda2;

            if (lamaPeminjaman > 5 && lamaPeminjaman <= 10)
            {
                Console.Write("Total denda : Rp." + totalDenda * lamaPeminjaman1);
            }
            else if(lamaPeminjaman > 10 && lamaPeminjaman <= 30)
            {
                Console.Write("Total denda : Rp." + denda2);
            }
            else if(lamaPeminjaman <=5){
                Console.Write("Total denda : Rp.0");
            }
            else
            {
                Console.WriteLine("Keanggotaan anda dibatalkan");
                Console.Write("Total denda : Rp." + denda3);
            }
        }
    }
}