using System;
using System.Collections.Generic;
using System.Text;

namespace Taller
{
    class Moto:TransportesdeReparo
    {

        public Moto() : base() { }
        public Moto(string marca, string color, int modelo) : base()
        {
            this.Marca = marca;
            this.Color = color;
            this.Modelo = modelo;
        }
            
            public string EncenderMoto()
        {
            return $"Prendida la Moto {Modelo} que tiene {Color}";
        }
        public string ApagarMoto()
        {
            return $"la Moto esta apagada";
        }
        public string Acelerar()
        {
            return "Acelerando";
        }

        public string Desacelerar()
        {
            return "Frenando";
        }
    }
}
