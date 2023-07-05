using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DriveLibrary;

namespace DriveConsoleApp
{
    internal class Program
    {
        //Сантурян
        static void Main(string[] args)
        {
            Driver driver = new Driver("SanT", "B");
            Auto genesis = new Auto("G90", "A122AB");
            Auto genesis2 = new Auto("G90", "A102AB");
            Auto jaguar = new Auto("F", "A123AB");
            Auto mazda = new Auto("rx7", "A124AB");
            Driver driverTest = new Driver("SanT", "B", new List<Auto> { genesis, jaguar, mazda});

            driver.AddAuto(genesis);
            driver.AddAuto(jaguar);
            driver.AddAuto(mazda);

            Console.WriteLine(driver.ShowAll());
            Console.WriteLine(driverTest.ShowAll());
            Console.WriteLine(genesis.CompareTo(jaguar));
            Console.WriteLine(genesis.CompareTo(genesis2));

            Console.ReadLine();
        }
    }
}
