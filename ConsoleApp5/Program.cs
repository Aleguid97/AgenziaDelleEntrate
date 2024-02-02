using ConsoleApp4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╔══════════════════════════════════╗");
            Console.WriteLine("║                                  ║");
            Console.WriteLine("║           Agenzia delle          ║");
            Console.WriteLine("║              Entrate             ║");
            Console.WriteLine("║                                  ║");
            Console.WriteLine("╚══════════════════════════════════╝");
            Console.WriteLine("\n");

            Contribuente contribuente = new Contribuente();
            contribuente.GetName();
            Console.WriteLine("\n");
            contribuente.GetSurname();
            Console.WriteLine("\n");
            contribuente.GetCity();
            Console.WriteLine("\n");
            contribuente.CheckData();
            Console.WriteLine("\n");
            contribuente.CheckSex();
            Console.WriteLine("\n");
            contribuente.GetValidCF();
            Console.WriteLine("\n");
            contribuente.CheckIncome();
            Console.WriteLine("\n");
            contribuente.Details();




        }
    }
}
