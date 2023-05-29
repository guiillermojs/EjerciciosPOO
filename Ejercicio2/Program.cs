using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("De el nombre de la casa comercial: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el email: ");
            string email = Console.ReadLine();

            //Definimos un nuevo objeto de tipo Casa Comercial
            CasaComercial cc = new CasaComercial(nombre, email, 0, new List<Vehiculo>());

            //informacion del nuevo vehiculo a añadir
            Console.WriteLine("A continuacion de la informacion del primer vehiculo a añadir: ");
            Console.WriteLine("Modelo: ");
            string modelo = Console.ReadLine();
            Console.WriteLine("Marca: ");
            string marca = Console.ReadLine();
            Console.WriteLine("Kilometraje: ");
            int km = int.Parse(Console.ReadLine());
            Console.WriteLine("Precio: ");
            decimal precio = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Año: ");
            int annio = int.Parse(Console.ReadLine());

            /*procedemos a añadir la informacion del nuevo vehiculo haciendo uso del metodo "añadir vehiculo"
            definido en la clase casa comercial*/

            cc.AnadirVehiculo(new Vehiculo(1, marca, modelo, km, precio, annio));
            Console.WriteLine("Lista de vehículos registrados");
            cc.MotrarVehiculos();
            Console.WriteLine("\nDesea vaciar la lista: S/N");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 'S' || resp == 's')
            {
                cc.VaciarVehiculo();
            }

            Console.WriteLine("\nQuiere borrar un vehiculo de la lista? S/N");
            char resp2 = char.Parse(Console.ReadLine());

            if (resp2 == 'S' || resp2 == 's')
            {
                Console.WriteLine("Ingrese el numero de Id de su vehiculo");
                int id = int.Parse(Console.ReadLine());

                if (id == 1)
                {
                    Console.WriteLine("\nIngrese los datos del vehiculo que desea borrar");

                    Console.WriteLine("Modelo: ");
                    string modelo_1 = Console.ReadLine();
                    Console.WriteLine("Marca: ");
                    string marca_1 = Console.ReadLine();
                    Console.WriteLine("Kilometraje: ");
                    int km_1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Annio: ");
                    int annio_1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Precio: ");
                    decimal precio_1 = decimal.Parse(Console.ReadLine());

                    Vehiculo vehiculo_eliminar = new Vehiculo(1, marca_1, modelo_1, km_1, precio_1, annio_1);
                    cc.EliminarVehiculo(vehiculo_eliminar);
                }

                if (id == 2)
                {
                    Console.WriteLine("\nIngrese los datos del vehiculo que desea borrar");

                    Console.WriteLine("Modelo: ");
                    string modelo_2 = Console.ReadLine();
                    Console.WriteLine("Marca: ");
                    string marca_2 = Console.ReadLine();
                    Console.WriteLine("Kilometraje: ");
                    int km_2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Annio: ");
                    int annio_2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Precio: ");
                    decimal precio_2 = decimal.Parse(Console.ReadLine());

                    Vehiculo vehiculo_eliminar = new Vehiculo(2, marca_2, modelo_2, km_2, precio_2, annio_2);
                    cc.EliminarVehiculo(vehiculo_eliminar);
                }

                else
                {
                    Console.WriteLine("No se encontró el vehiculo");
                }
            }

            Console.ReadKey();
        }
    }
}
