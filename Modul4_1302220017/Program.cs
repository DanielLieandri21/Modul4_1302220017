using modul4_1302220017;
using static modul4_1302220017.KodeBuah;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nama Buah | Kode Buah  \n");
        KodeBuah kodeBuah = new KodeBuah();
        Console.WriteLine("Apel\t: " + kodeBuah.GetKodeBuah(Buah.Apel));
        Console.WriteLine("Aprikot\t: " + kodeBuah.GetKodeBuah(Buah.Aprikot));
        Console.WriteLine("Alpukat\t: " + kodeBuah.GetKodeBuah(Buah.Alpukat));
        Console.WriteLine("Pisang\t: " + kodeBuah.GetKodeBuah(Buah.Pisang));
        Console.WriteLine("Paprika\t: " + kodeBuah.GetKodeBuah(Buah.Paprika));
        Console.WriteLine("Blackberry\t: " + kodeBuah.GetKodeBuah(Buah.Blackberry));
        Console.WriteLine("Ceri\t: " + kodeBuah.GetKodeBuah(Buah.Ceri));
        Console.WriteLine("Kelapa\t: " + kodeBuah.GetKodeBuah(Buah.Kelapa));
        Console.WriteLine("Jagung\t: " + kodeBuah.GetKodeBuah(Buah.Jagung));
        Console.WriteLine("Kurma\t: " + kodeBuah.GetKodeBuah(Buah.Kurma));
        Console.WriteLine("Durian\t: " + kodeBuah.GetKodeBuah(Buah.Durian));
        Console.WriteLine("Anggur\t: " + kodeBuah.GetKodeBuah(Buah.Anggur));
        Console.WriteLine("Melon\t: " + kodeBuah.GetKodeBuah(Buah.Melon));
        Console.WriteLine("Semangka\t: " + kodeBuah.GetKodeBuah(Buah.Semangka));

        /* Commit "menambahkan implementasi dengan table-driven"

        Console.WriteLine("\n\n\nNomor 5 A-E : \n");

        DoorMachine door = new DoorMachine();
        door.DoAction(Action.BukaPintu);
        door.DoAction(Action.KunciPintu);
        door.DoAction(Action.KunciPintu); // Kunci lagi, tidak akan terjadi apa-apa karena pintu sudah terkunci
        door.DoAction(Action.BukaPintu);

        // Commit "menambahkan implementasi dengan state-based construction"*/
    }
}