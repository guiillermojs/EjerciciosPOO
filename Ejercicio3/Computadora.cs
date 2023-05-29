using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Computadora
    {
        decimal capacidad_disco;
        decimal espacio_disponible;
        bool encendido = false;

        public Computadora(decimal capacidad_disco, decimal espacio_disponible, bool encendido)
        {
            this.capacidad_disco = capacidad_disco;
            this.espacio_disponible = espacio_disponible;
            this.encendido = encendido;
        }

        public decimal Capacidad_disco { get => capacidad_disco; set => capacidad_disco = value; }
        public decimal Espacio_disponible { get => espacio_disponible; set => espacio_disponible = value; }
        public bool Encendido { get => encendido; set => encendido = value; }


        public Computadora(int capacidad_disco)
        {
            this.capacidad_disco = capacidad_disco;
            espacio_disponible = 0;
            encendido = false;
        }

        public void AniadirDatos(int datos)
        {

            if (encendido)
            {
                int espacio_libre = (int)capacidad_disco - (int)espacio_disponible;

                if (datos <= espacio_libre)
                {
                    espacio_disponible += datos;
                    Console.WriteLine("Se añadierón los datos correctamente.");
                }
                else
                {
                    espacio_disponible = capacidad_disco;
                    Console.WriteLine("El disco duro está lleno.");
                }
            }
            else
            {
                Console.WriteLine("La Computadora está apagada.");
            }
        }

        public void EliminarDatos(int datos)
        {
            if (encendido)
            {
                if (datos <= espacio_disponible)
                {
                    espacio_disponible = espacio_disponible - datos;
                    Console.WriteLine("Se eliminaron los datos correctamente.");
                }

                else
                {
                    espacio_disponible = 0;
                    Console.WriteLine("El disco duro está vacío.");
                }
            }
            else
            {
                Console.WriteLine("La Computadora está apagada.");
            }
        }

        public void Encender()
        {
            if (!encendido)
            {
                encendido = true;
                Console.WriteLine("Bienvendido");
            }
            else
            {
                Console.WriteLine("La Computadora ya está encendida.");
            }
        }

        public void Apagar()
        {
            if (encendido)
            {
                encendido = false;
                Console.WriteLine("Good-Bye");
            }
            else
            {
                Console.WriteLine("La Computadora ya está apagada.");
            }
        }
    }
}
