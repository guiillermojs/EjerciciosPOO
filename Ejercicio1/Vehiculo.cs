using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Vehiculo
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double KM { get; set; }
        public double Precio { get; set; }
        public int Anio { get; set; }

        public Vehiculo(int id, string marca, string modelo, double km, double precio, int anio)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
            KM = km;
            Precio = precio;
            Anio = anio;
        }

        public override string ToString()
        {
            return $"Marca: {Marca}\nModelo: {Modelo}\nAño: {Anio}\nPrecio: {Precio:C}";
        }
    }
}
