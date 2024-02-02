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
            


            Console.WriteLine("╔══════════════════════════════════╗");
            Console.WriteLine("║                                  ║");
            Console.WriteLine("║           Agenzia delle          ║");
            Console.WriteLine("║              Entrate             ║");
            Console.WriteLine("║                                  ║");
            Console.WriteLine("╚══════════════════════════════════╝");
            Console.WriteLine("\n");

            Contribuente contribuente = new Contribuente();
            contribuente.GetName();
            contribuente.GetSurname();
            contribuente.GetCity();
            contribuente.CheckData();
            contribuente.CheckSex();
            contribuente.GetValidCF();
            contribuente.CheckIncome();
            contribuente.Details();




        }
    }
}
