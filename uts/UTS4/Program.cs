using System;

namespace UTS4suit
{
    class Program
    {
        static Random pilihan = new Random();
        static int skorSeri;
        static int skorMenang;
        static int skorKalah;
        static bool gamePlay;

        static void Main(string[] args)
        {
            gamePlay = true;
            while (gamePlay)
            {
                Console.Clear();
                Console.WriteLine("Batu, Gunting, Kertas");
                Console.Write("\nChoose [b]atu, [g]unting, [k]ertas, or [e]xit:");

                string pilihanAnda = Console.ReadLine();
                if (pilihanAnda == "e")
                {
                    break;
                }

                int pilihanKomputer = pilihan.Next(0, 3);
                if (pilihanKomputer == 0)
                {
                    Console.WriteLine("Komputer memilih batu.");

                    switch(pilihanAnda)
                    {
                        case "b":
                        Console.WriteLine("Seri.");
                        skorSeri++;
                        break;

                        case  "g":
                        Console.WriteLine("Anda kalah.");
                        skorKalah++;
                        break;

                        case "k":
                        Console.WriteLine("Anda menang.");
                        skorMenang++;
                        break;
                    }
                }

                else if (pilihanKomputer == 1)
                {
                    Console.WriteLine("Komputer memilih gunting");

                    switch(pilihanAnda)
                    {
                            case "b":
                        Console.WriteLine("Anda menang.");
                        skorMenang++;
                        break;

                        case  "g":
                        Console.WriteLine("Seri.");
                        skorSeri++;
                        break;

                        case "k":
                        Console.WriteLine("Anda Kalah.");
                        skorKalah++;
                        break;
                    }
                }

                else
                {
                    Console.WriteLine("Komputer memilih kertas");

                    switch(pilihanAnda)
                    {
                            case "b":
                        Console.WriteLine("Anda kalah.");
                        skorKalah++;
                        break;

                        case  "g":
                        Console.WriteLine("Anda Menang.");
                        skorMenang++;
                        break;

                        case "k":
                        Console.WriteLine("Seri.");
                        skorSeri++;
                        break;
                    }
                }

                Console.WriteLine($"Skor: {skorMenang} menang, {skorKalah} kalah, {skorSeri} seri");
                Console.WriteLine("Tekan enter untuk melanjutkan permainan...");
                while (Console.ReadKey().Key!= ConsoleKey.Enter)
                {
                    Console.Clear();
                    gamePlay = true;
                }
            }
        }
    }
}