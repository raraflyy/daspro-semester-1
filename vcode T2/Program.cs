using System;

namespace DasarPemrograman
{
    class Program
    {
        //Main Method
        
        static void Main(string[] args)
        {
           
            //Deklarasi Variabel
            int kodeA;
            int kodeB;
            int kodeC;
            int jumlahKode;
            String tebakanAnda;
            String tebakanA;
            String tebakanB;
            String tebakanC;

            //Inisialisai Variabel
            kodeA = 9;
            kodeB = 3;
            kodeC = 3;
            jumlahKode = 3;

            //Operasi Aritmatika
            int hasilTambah = kodeA+kodeB+kodeC;
            int hasilKali = kodeA*kodeB*kodeC;

            //Intro
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui");
            Console.WriteLine("Password terdiri dari "+jumlahKode+" angka");
            Console.WriteLine("Jika ditambahkan hasilnya "+hasilTambah);
            Console.WriteLine("Jika dikalikan hasilnya "+hasilKali);

            //Input User
            Console.Write("Masukan Kode  1 : ");
            tebakanA = Console.ReadLine();
            Console.Write("Masukan Kode  2 : ");
            tebakanB = Console.ReadLine();
            Console.Write("Masukan Kode  3 : ");
            tebakanC = Console.ReadLine();

            Console.WriteLine("Tebakan Anda : "+ tebakanA+" "+tebakanB+" "+tebakanC+"?");

            if(tebakanA == kodeA.ToString() && tebakanB == kodeB.ToString() && tebakanC == kodeC.ToString())
            {
                Console.WriteLine("Acces Accepted");
            }
            else
            {
                Console.WriteLine("Acces Denied");
            }
        }
    }
}
