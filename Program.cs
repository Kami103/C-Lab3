using System.Data.SqlTypes;

namespace ConsoleApp3;

internal class Program
{
    private static void Main(string[] args)
    {
        //zadanie nr1
        Console.WriteLine("zadanie nr1");
        Osoba o1 = new Osoba("Kamil","Nowak");
        Console.WriteLine(o1.ZwrocPelnaNazwe());
        Osoba o2 = new Osoba();
        o2.SetImie("Jan");
        o2.SetNazwisko("Kowalski");
        Osoba o3 = new Osoba("Anna","Annowska");
        Console.WriteLine(o2.ZwrocPelnaNazwe());
        List<Osoba> list = new List<Osoba>();
        list.Add(o1);
        list.Add(o2);
        list.Add(o3);
        
        //zadanie nr2
        Console.WriteLine("zadanie nr2");
        list.WypiszOsoby();
        
        //zadanie nr3
        Console.WriteLine("zadanie nr3");
        list.PosortujOsobyPoNazwisku();
        list.WypiszOsoby();
        
        //zadanie nr4
        Console.WriteLine("zadanie nr4");
        Student s1 = new Student();
        s1.SetImie("Jan");
        s1.SetNazwisko("Nowak");
        s1.SetUczelania("UR");
        s1.SetKierunek("Matematyka");
        s1.SetRok("II");
        s1.SetSemestr("1");
        Console.WriteLine(s1.WypiszPelnaNazweIUczelnie());
        
        //zadanie nr5
        Console.WriteLine("zadanie nr5");
        StudentUR st1 = new StudentUR("Janusz","Kowalski","nie ma znaczrnia","Infomatyka","2","1");
        StudentUR st2 = new StudentUR("Monika","Nowak","UR","Matemtyka","3","3");
        List<StudentUR> listaUR = new List<StudentUR>();
        listaUR.Add(st1);
        listaUR.Add(st2);
        listaUR.WypiszOsoby();

    }

    
}