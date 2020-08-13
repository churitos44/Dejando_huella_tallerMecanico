using System;
using System.Collections.Generic;
using System.Text;

namespace Taller
{
    class TransportesdeReparo:GeneradorAutomaticoIdentificador
    {
        
        public TransportesdeReparo() :base () {}
        public string Marca { get; set; }
        public int Modelo { get; set; }
        public string Color { get; set; }
        public int Matricula { get; set; }

    }
}
