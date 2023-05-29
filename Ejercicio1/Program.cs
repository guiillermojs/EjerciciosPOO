using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo vehiculo = new Vehiculo(1, "Ford", "Mustang", 10000, 25000, 2021);
            Console.WriteLine(vehiculo.ToString());
            Console.ReadLine();
        }
    }
}
