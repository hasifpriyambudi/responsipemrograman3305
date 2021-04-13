using System;

namespace ResponsiPemrograman3305{
    class Program{
        static void Main(string[] args){
            // Deklarasi Variabel
            Karyawan karyawan = new Karyawan();
            karyawan.Nik = "123456789";
            karyawan.Nama = "Sluwu";
            karyawan.GajiBulanan = 3000000;

            karyawan.infoKaryawan();
            karyawan.naikGaji();
        }
    }
}
