// See https://aka.ms/new-console-template for more information

using System;

public class KodeBuah
{
    public enum namabuah {Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka};
    public string get_kode_buah(namabuah buah)
    {
        string[] Kode = {"A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00"};
        return Kode[(int) buah];
    }
}