using System;
using System.Collections.Generic;
using System.Text;

namespace Taller
{
    class Tractor : TransportesdeReparo
    {
        public Tractor() : base() { }


        public string EncenderTractor()
        {
            return $"Prendida";
        }
        public string Apagartractor()
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
