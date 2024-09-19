using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KomarovaMV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KomarovaMV.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Маргарита"));
            Console.ReadKey();
        }
    }
}
