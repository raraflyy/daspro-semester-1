//rafly wirangga
//2207112577

using System;
using System.Collections.Generic;

namespace tebakkata
{
    class Program
    {
        static int kesempatan=5;
        static String katamisteri ="doraemon";
        static List<string> listtebakan = new List<string>{};
        static void Main(string[] args)
        {
            intro();
            playgame();
            endgame();
        }
        static void intro()
        {
            Console.WriteLine("Wellcome,hari ini kita akan bermain tebak kata");
            Console.WriteLine($"kamu punya {kesempatan} untuk menebak kata misteri hari ini");
            Console.WriteLine("petunjuknya adalah kata ini merupakan film animasi terkenal yang berasal dari Jepang");
            Console.WriteLine($"kata tersebut terdiri dari {katamisteri.Length} huruf");
            Console.WriteLine("apakah kata misteri tersebut?");
            Console.ReadKey();
            Console.WriteLine();
        }
        static void playgame()
        {
            while (kesempatan>0)
            {
                Console.Write("apa huruf tebakanmu?(a - z) :");string input = Console.ReadLine();
                listtebakan.Add(input);
                if (cekjawaban(katamisteri, listtebakan))
                {
                    Console.WriteLine("selamat anda berhasil");
                    Console.WriteLine($"kata misteri hari ini adalah {katamisteri}");
                    break;
                }
                else if (katamisteri.Contains(input))
                {
                    Console.WriteLine("huruf itu ada di kata ini");
                    Console.WriteLine("silahkan tebak huruf lainnya");
                    Console.WriteLine(cekhuruf(katamisteri, listtebakan));
                }
                else
                {
                    Console.WriteLine("huruf itu tidak ada di kata ini");
                    kesempatan--;
                    Console.WriteLine($"kesempatan anda tinggal {kesempatan}");
                }
                
                if (kesempatan==0)
                {
                    endgame();
                    break;
                }
            }
        }
        static bool cekjawaban(string katarahasia, List<string> list)
    {bool status = false;
        for (int i = 0; i < katarahasia.Length; i++)
        {
            string c = Convert.ToString(katarahasia[i]);
            if (list.Contains(c))
            {
                status = true;
            }
            else
            {
                return status = false;
            }
        }
        return status;
    }
        static string cekhuruf(string katarahasia, List<string> list)
        {string x = "";

        for (int i = 0; i < katarahasia.Length; i++)
        {
            string c = Convert.ToString(katarahasia[i]);
            if (list.Contains(c))
            {
                x = x + c;
            }
            else
            {
                x =  x + "_";
            }
        }
            return x;
        }
        static void endgame()
        {
            if (kesempatan == 0)
            {
            Console.WriteLine("Permainan berakhir");
            Console.WriteLine($"kata misterinya adalah {katamisteri}");
            }
        }
    }

}