using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var numaralar = new List<string> { "LAB-001", "LAB-002", "LAB-003" };
        var bosListe = new List<string>();

        Dene("İlk eleman", numaralar, "LAB-001", true);
        Dene("Son eleman", numaralar, "LAB-003", true);
        Dene("Olmayan numara", numaralar, "LAB-999", false);
        Dene("Boş liste", bosListe, "LAB-001", false);
    }

    static bool NumaraVarMi(List<string> liste, string aranan)
    {
        foreach (string numara in liste)
        {
            if (numara == aranan)
                return true;
        }

        return false;
    }

    static void Dene(string senaryo, List<string> liste, string aranan, bool beklenen)
    {
        bool sonuc = NumaraVarMi(liste, aranan);
        string durum = sonuc == beklenen ? "DOĞRU" : "HATALI";
        Console.WriteLine($"{senaryo,-15} aranan={aranan,-8} sonuç={sonuc,-5} beklenen={beklenen,-5} -> {durum}");
    }
}