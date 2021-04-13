using System;

namespace ResponsiPemrograman3305
{
    public class Karyawan{
        public string Nik {get;set;}
        public string Nama {get;set;}
        public int GajiBulanan {get;set;}
        
        public void infoKaryawan(){
            Console.WriteLine("No NIK/Nama              Gaji Bulanan");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1. {0}/{1}             Rp.{2:#,0}",Nik,Nama,GajiBulanan);
        }

        public void naikGaji(){
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            

            Console.WriteLine("Alhamdulilah dapat kenaikan gaji 10%");
            int naik = (GajiBulanan/100)*10;
            int hasilAkhir = naik+GajiBulanan;
            Console.WriteLine("No NIK/Nama              Gaji Bulanan");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1. {0}/{1}             Rp.{2:#,0}",Nik,Nama,hasilAkhir);
        }
    }
}
