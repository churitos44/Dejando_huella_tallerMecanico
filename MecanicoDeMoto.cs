using System;
using System.Collections.Generic;
using System.Text;

namespace Mecanicos.Interfaz
{
    class MecanicoDeMoto:IMecanico
    {
        public string repararMotor()
        {
            return "estoy Reparando ";
        }
        public string cambiarFrenos()
        {
            return "estoy cambiando los frenos de una moto ";
        }
        public string cambiarAceite()
        {
            return "aceite cambiado  una moto";
        }
        public string ajustarTurcas()
        {
            return "ajuantando tuercas  una moto";
        }
        public string revisarABC()
        {
            return " haciendo AbC  una moto";
        }
    }
}
