using System;
using System.Collections.Generic;
using System.Text;

namespace Taller
{
    class Carro:TransportesdeReparo
    {
        public Carro() : base() { }


        public string Describir()
        {
            return $"numero de  matricula del carro: {Matricula} marca del carro: {Marca} modelo :{Modelo} y por ultimo colordel carro :{Color}";
        }
        public string EncenderCarro()
        {
            return $"Prendido";
        }
        public string ApagarCarro()
        {
            return $"el carro esta con marca:{Marca}y modelo:{Modelo} esta prendido";
        }
        public string Acelerar()
        {
            return "Acelerando";
        }

        public string Frenar()
        {
            return "Frenando";
        }



    }




}
