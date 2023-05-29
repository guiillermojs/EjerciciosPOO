using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese 2 fotos: ");
            Console.WriteLine("Foto1: ");

            Console.WriteLine("Id: ");
            int id1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tamaño: ");
            decimal tamaño1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Fecha: ");
            DateTime fecha1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Comentario: ");
            string comentario1 = Console.ReadLine();

            Console.WriteLine("Foto2: ");

            Console.WriteLine("Id: ");
            int id2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tamaño: ");
            decimal tamaño2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Fecha: ");
            DateTime fecha2 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Comentario: ");
            string comentario2 = Console.ReadLine();




            Foto foto1 = new Foto(id1, tamaño1, fecha1, comentario1);
            Foto foto2 = new Foto(id2, tamaño2, fecha2, comentario2);

            var fotos = new List<Foto> { foto1, foto2 };

            Album album1 = new Album(1, "Vacaciones", new DateTime(2022, 4, 15), fotos);


            album1.AniadirFoto(foto1);
            album1.AniadirFoto(foto2);
            Console.WriteLine("Fotos en el álbum: ", album1.Nombre);
            album1.MostrarFotos();

            album1.EliminarFoto(foto2);
            Console.WriteLine("Fotos en el álbum (actualizado): ", album1.Nombre);
            album1.MostrarFotos();

            double tamanoGb = album1.TamanoAlbum();
            Console.WriteLine("Tamaño del álbum {0}': {1} GB" + album1.Nombre + tamanoGb);


            album1.VaciarAlbum();


            Console.WriteLine("Fotos en el álbum '{0}' (vacío):" + album1.Nombre);
            album1.MostrarFotos();

            Console.ReadKey();
        }
    }
}
