namespace ConsoleApp3;

static class Extensions
{
    public static void WypiszOsoby(this List<Osoba> lista)
    {
        foreach (var VARIABLE in lista)
        {
            Console.WriteLine(VARIABLE.ZwrocPelnaNazwe());
        }
    }public static void WypiszOsoby(this List<StudentUR> lista)
    {
        foreach (var VARIABLE in lista)
        {
            Console.WriteLine(VARIABLE.WypiszPelnaNazweIUczelnie());
        }
    }
    public static void PosortujOsobyPoNazwisku(this List<Osoba> lista)
    {
        lista.Sort((osoba1,osoba2)=>osoba1.GetNazwiko().CompareTo(osoba2.GetNazwiko()));
    }
}