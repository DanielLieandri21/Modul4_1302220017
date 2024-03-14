using System;
namespace modul4_1302220017;

using System.Collections.Generic;

public class KodeBuah
{
    private Dictionary<string, string> kodeBuahDictionary;

    public enum Buah
    {
        Apel,
        Aprikot,
        Alpukat,
        Pisang,
        Paprika,
        Blackberry,
        Ceri,
        Kelapa,
        Jagung,
        Kurma,
        Durian,
        Anggur,
        Melon,
        Semangka
    }

    public string GetKodeBuah(Buah buah)
    {
        String[] kodeBuah =
            {
            "A00", // Apel
            "B00", // Aprikot
            "C00", // Alpukat
            "D00", // Pisang
            "E00", // Paprika
            "F00", // Blackberry
            "H00", // Ceri
            "I00", // Kelapa
            "J00", // Jagung
            "K00", // Kurma
            "L00", // Durian
            "M00", // Anggur
            "N00", // Melon
            "O00"  // Semangka
            };
        int index = (int)buah;
        if (index >= 0 && index < kodeBuah.Length)
        {
            return kodeBuah[index];
        }
        return "Kode Buah Tidak Ditemukan";
    }
}
