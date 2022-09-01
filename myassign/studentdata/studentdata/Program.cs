using System;
using Microsoft. VisualBasic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentdata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String data = System.IO.File.ReadAllText(@"C:\Users\Texas\myassign\studentdata.txt");
            Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.WriteLine("Rainbow school students report: " +data);
            Console.ReadLine();
        }
    }
}
