// See https://aka.ms/new-console-template for more information

using MODUL4_1302213045;
using System;
class main
{
    static void Main(String[] args)
    {
        KodeBuah buah= new KodeBuah();
        Console.WriteLine(buah.get_kode_buah(KodeBuah.namabuah.Apel));
        Console.WriteLine(buah.get_kode_buah(KodeBuah.namabuah.Aprikot));
        Console.WriteLine(buah.get_kode_buah(KodeBuah.namabuah.Alpukat));
        Console.WriteLine(buah.get_kode_buah(KodeBuah.namabuah.Pisang));
        Console.WriteLine(buah.get_kode_buah(KodeBuah.namabuah.Paprika));
        Console.WriteLine(buah.get_kode_buah(KodeBuah.namabuah.Blackberry));
        Console.WriteLine(buah.get_kode_buah(KodeBuah.namabuah.Ceri));
        Console.WriteLine(buah.get_kode_buah(KodeBuah.namabuah.Kelapa));
        Console.WriteLine(buah.get_kode_buah(KodeBuah.namabuah.Jagung));
        Console.WriteLine(buah.get_kode_buah(KodeBuah.namabuah.Kurma));
        Console.WriteLine(buah.get_kode_buah(KodeBuah.namabuah.Durian));
        Console.WriteLine(buah.get_kode_buah(KodeBuah.namabuah.Anggur));
        Console.WriteLine(buah.get_kode_buah(KodeBuah.namabuah.Melon));
        Console.WriteLine(buah.get_kode_buah(KodeBuah.namabuah.Semangka));

        PosisiKarakterGame gas = new PosisiKarakterGame();
        gas.mulai();
    }
}