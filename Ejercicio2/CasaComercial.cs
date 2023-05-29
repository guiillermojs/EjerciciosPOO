using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class CasaComercial
    {
        //Campos de la clase Casa Comercial
        string nombre;
        string correo;
        int total;
        //Esto es composicion ya que la clase de casa comercial posee una lista de objetos de tipo vehiculos
        List<Vehiculo> vehiculos;

        //Constructor
        public CasaComercial(string nombre, string correo, int total, List<Vehiculo> vehiculos)
        {
            this.nombre = nombre;
            this.correo = correo;
            this.total = total;
            this.vehiculos = vehiculos;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Total { get => total; set => total = value; }
        internal List<Vehiculo> Vehiculos { get => vehiculos; set => vehiculos = value; }

        //Añadimos cada uno de los metodos
        public void AnadirVehiculo(Vehiculo V)
        {
            try
            {
                //Añnadimos un nuevo objeto a la lista vheiculo
                this.vehiculos.Add(V);
                //Actualizamos el total de vehiculos
                this.total += 1;
                Console.WriteLine("Se ha añadido un nuevo vehiculo");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo añadir debido a: \n" + ex.Message);
                Console.ReadLine();
            }
        }
        public void MotrarVehiculos()
        {
            foreach (var item in this.vehiculos)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine("----------------");
            }
        }
        public void VaciarVehiculo()
        {
            Console.WriteLine("Esta seguro que desea eliminar todos los elmentos mostrados en la lista?: S/N");
            string response = Console.ReadLine();
            if (response == "S" || response == "s")
            {
                vehiculos = new List<Vehiculo>();
                this.total = 0;
                Console.WriteLine("Se han eliminado los objetos correctamente");
            }
            else
            {
                Console.WriteLine("No se elimino. Hay {0} vehiculos registrados", total);
            }
            Console.ReadLine();
        }
        public void EliminarVehiculo(Vehiculo V)
        {
            vehiculos.Remove(V);
            total -= 1;
            Console.WriteLine("Se ha eliminado un registro");
            Console.ReadLine();
        }
    }
}
