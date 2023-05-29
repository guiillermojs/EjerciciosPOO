using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Vehiculo
    {
        int id;
        string marca;
        string model;
        int km;
        decimal precio;
        int annio;

        public Vehiculo(int id, string marca, string model, int km, decimal precio, int annio)
        {
            this.Id = id;
            this.Marca = marca;
            this.Model = model;
            this.Km = km;
            this.Precio = precio;
            this.Annio = annio;
        }
        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Model { get => model; set => model = value; }
        public int Km { get => km; set => km = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Annio { get => annio; set => annio = value; }

        public override string ToString()
        {
            return "Modelo: " + Model + "\nMarca: " + Marca + "\nKilometraje: " + Km + "\nPrecio: " + Precio + "\nAnnio: " + Annio;
        }
    }
    class Auto : Vehiculo
    {
        bool airbag;

        public Auto(int id, string marca, string model, int km, decimal precio, int annio, bool airbag) : base(id, marca, model, km, precio, annio)
        {
            this.airbag = airbag;
        }

        public bool Airbag { get => airbag; set => airbag = value; }


        public override string ToString()
        {
            if (airbag)
            {
                return "Modelo: " + base.Model + "\nMarca: " + base.Marca + "\nKilometraje: " + base.Km + "\nPrecio: " + (base.Precio + (decimal)200) + "\nAnnio: " + base.Annio;
            }
            else
            {
                return "Modelo: " + base.Model + "\nMarca: " + base.Marca + "\nKilometraje: " + base.Km + "\nPrecio: " + base.Precio + "\nAnnio: " + base.Annio;
            }

        }

    }

    class Moto : Vehiculo
    {

        bool sidecar;

        public Moto(int id, string marca, string model, int km, decimal precio, int annio, bool sidecar) : base(id, marca, model, km, precio, annio)
        {
            this.sidecar = sidecar;
        }


        public bool Sidecar { get => sidecar; set => sidecar = value; }


        public override string ToString()
        {
            if (sidecar)
            {
                return "Modelo: " + base.Model + "\nMarca: " + base.Marca + "\nKilometraje: " + base.Km + "\nPrecio: " + (base.Precio + (decimal)50) + "\nAnnio: " + base.Annio;
            }
            else
            {
                return "Modelo: " + base.Model + "\nMarca: " + base.Marca + "\nKilometraje: " + base.Km + "\nPrecio: " + base.Precio + "\nAnnio: " + base.Annio;
            }

        }
    }
}
