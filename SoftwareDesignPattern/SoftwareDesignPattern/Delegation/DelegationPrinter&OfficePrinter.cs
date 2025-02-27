using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPattern.Delegation
{
    public class Printer
    {
        public void Print(string message)
        {
            Console.WriteLine("Printing: " + message);
        }
    }

    public class OfficePrinter
    {
        private Printer _printer = new Printer(); // Delegation

        public void PrintDocument(string message)
        {
            _printer.Print(message); // Delegating to Printer class
        }
    }
}
