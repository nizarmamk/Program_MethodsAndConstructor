using MethodsAndConstructor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numbers nilai = new Numbers();

            nilai.CariNilaiMin(4, 8, 2);
            nilai.CariNilaiMin(7, 1, 5);
            nilai.CariNilaiMin(9, 9, 9);
            Console.WriteLine("====================================================");
            nilai.CariNilaiMax(6, 3, 9);
            nilai.CariNilaiMax(60, 45, 30);
            nilai.CariNilaiMax(19, 19, 19);
            Console.ReadKey();
        }
    }
}
