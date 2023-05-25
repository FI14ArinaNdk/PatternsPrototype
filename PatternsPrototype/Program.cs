using PatternsPrototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Milk milk = new Milk();
        milk.Price = 42;
        milk.ExpirationDate = 34;
        milk.Name = "Galychina";
        milk.IdInfo = new IdInfo(938716483);

        Milk milk1 = milk.IncompleteCopy();
        Milk milk2 = milk.CompleteCopy();

        Console.WriteLine("   milk : ");
        DisplayData(milk);
        Console.WriteLine("   milk1 :");
        DisplayData(milk1);
        Console.WriteLine("   milk2 :");
        DisplayData(milk2);

        milk.Price = 32;
        milk.ExpirationDate = 7;
        milk.Name = "Ferma";
        milk.IdInfo.IdNumber = 836184920;
        Console.WriteLine("changes");
        Console.WriteLine("   milk : ");
        DisplayData(milk);
        Console.WriteLine("   milk1 : ");
        DisplayData(milk1);
        Console.WriteLine("   milk2 :");
        DisplayData(milk2);
    }

    public static void DisplayData(Milk milk)
    {
        Console.WriteLine("    Name: {0:s}, Price: {1:d}, ExpirationDate: {2:d} , ID#: {3:d}", milk.Name, milk.Price, milk.ExpirationDate, milk.IdInfo.IdNumber);

    }
}