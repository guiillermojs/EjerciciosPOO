using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca los detalles del Auto:");
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Marca: ");
            string marca = Console.ReadLine();
            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();
            Console.Write("Kilometraje: ");
            int km = int.Parse(Console.ReadLine());
            Console.Write("Precio: ");
            decimal precio = decimal.Parse(Console.ReadLine());
            Console.Write("Año: ");
            int annio = int.Parse(Console.ReadLine());
            Console.Write("Airbag (true/false): ");
            bool airbag = bool.Parse(Console.ReadLine());


            Auto auto = new Auto(id, marca, modelo, km, precio, annio, airbag);


            Console.WriteLine("\nDetalles del Auto:");
            Console.WriteLine(auto.ToString());


            Console.WriteLine("\nIngrese los detalles de la Moto:");
            Console.Write("Id: ");
            int id1 = int.Parse(Console.ReadLine());
            Console.Write("Marca: ");
            string marca1 = Console.ReadLine();
            Console.Write("Modelo: ");
            string modelo1 = Console.ReadLine();
            Console.Write("Kilometraje: ");
            int km1 = int.Parse(Console.ReadLine());
            Console.Write("Precio: ");
            decimal precio1 = decimal.Parse(Console.ReadLine());
            Console.Write("Año: ");
            int annio1 = int.Parse(Console.ReadLine());
            Console.Write("Sidecar (true/false): ");
            bool sidecar = bool.Parse(Console.ReadLine());


            Moto moto = new Moto(id1, marca1, modelo1, km1, precio1, annio1, sidecar);


            Console.WriteLine("\nDetalles de la Moto:");
            Console.WriteLine(moto.ToString());

            Console.ReadKey();
        }
    }
}
