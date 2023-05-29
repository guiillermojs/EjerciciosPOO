using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Album
    {
        int id;
        string nombre;
        DateTime fecha_creacion;
        List<Foto> ListaFotos;

        public Album(int id, string nombre, DateTime fecha_creacion, List<Foto> listaFotos)
        {
            this.id = id;
            this.nombre = nombre;
            this.fecha_creacion = fecha_creacion;
            ListaFotos = listaFotos;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime Fecha_creacion { get => fecha_creacion; set => fecha_creacion = value; }
        internal List<Foto> ListaFotos1 { get => ListaFotos; set => ListaFotos = value; }


        public void AniadirFoto(Foto f)
        {
            ListaFotos.Add(f);
            Console.WriteLine("Se ha añadido correctamente...");
        }

        public void MostrarFotos()
        {
            Console.WriteLine("\n\nMostrando Fotos...");

            foreach (Foto f in ListaFotos)
            {
                Console.WriteLine(f);
                Console.WriteLine("*******************************");
            }
        }

        public void VaciarAlbum()
        {
            Console.WriteLine("\n\nVaciando Album...");
            ListaFotos.Clear();
            Console.WriteLine("Se ha vaciado correctamente...");
        }

        public void EliminarFoto(Foto f)
        {
            ListaFotos.Remove(f);
            Console.WriteLine("Se ha eliminado correctamente...");
        }

        public double TamanoAlbum()
        {
            Console.WriteLine("Mostrando el tamaño...");
            decimal tamanoTotalMb = ListaFotos.Sum(f => f.Tamaño_mb);
            return (double)tamanoTotalMb / (double)1024.0;
        }
    }
}
