using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el tamaño del disco duro en GB");
            int capacidad = int.Parse(Console.ReadLine());

            Computadora PC1 = new Computadora(capacidad);

            Console.WriteLine("La computadora se encenderá automaticamente\n\n");

            PC1.Encender();

            Console.WriteLine("Ingrese los datos a añadir");
            int dato1 = int.Parse(Console.ReadLine());

            PC1.AniadirDatos(dato1);

            Console.WriteLine("Ingrese los datos a eliminar");
            int dato2 = int.Parse(Console.ReadLine());

            PC1.EliminarDatos(dato2);

            Console.WriteLine("La computadora se apagará automaticamente\n\n");
            PC1.Apagar();

            Console.ReadKey();
        }
    }
}
