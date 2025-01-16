Notatka PierwszaNotatka = new Notatka("Pierwsza", "zawartosc 1");
Notatka DrugaNotatka = new Notatka("Druga", "zawartosc 2");
PierwszaNotatka.Wyswietlanie();
PierwszaNotatka.Diagnostyka();
DrugaNotatka.Wyswietlanie();
DrugaNotatka.Diagnostyka();
class Notatka
{
    private static int Licznik = 0;
    private int id;
    protected string Tytul;
    protected string Tresc;
    public Notatka(string _tytul,string _tresc)
    {
        Tytul=_tytul;
        Tresc = _tresc;
        Licznik++;
        id = Licznik;
    }
    public void Wyswietlanie()
    {
        Console.WriteLine(Tytul);
        Console.WriteLine(Tresc);
    }
    public void Diagnostyka()
    {
        Console.Write(id.ToString());
        Console.Write(";");
        Console.Write(Tytul);
        Console.Write(";");
        Console.WriteLine(Tresc);
    }
}