using System;
using System.Collections.Generic;
using System.Text;

namespace Mecanicos.Interfaz
{
    class MecanicoDeTractor : IMecanico
    {
        public string ajustarTurcas()
        {
            return "estoy ajustando turcas de tractor";
        }

        public string cambiarAceite()
        {
            return "estoy haciendo el cambio de aceite de tractor";
        }

        public string cambiarFrenos()
        {
            return "estoy cambiando los frenos de tractor";
        }

        public string repararMotor()
        {
            return "estoy reparando el motor de tractor";
        }

        public string revisarABC()
        {
             return "revision  de tractor";
        }
    }
}
