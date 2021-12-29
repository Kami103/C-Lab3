namespace ConsoleApp3;

public class Osoba : IOsoba
{
    private String imie;
    private String nazwisko;

    public Osoba(string imie, string nazwisko)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
    }

    public Osoba()
    {
    }

    public void SetImie(string imie)
    {
        this.imie = imie;
    }

    public void SetNazwisko(string nazwiko)
    {
        this.nazwisko = nazwiko;
    }

    public string GetNazwiko()
    {
        return nazwisko;
    }

    public string ZwrocPelnaNazwe()
    {
        return imie + " " + nazwisko;
    }
}