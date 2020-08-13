using System;

namespace Mecanicos.Interfaz
{
    public class Mecanico:IMecanico
    {
        public string repararMotor()
        {
            return "estoy Reparando ";
        }
        public string cambiarFrenos()
        {
            return "estoy cambiando los frenos ";
        }
        public string cambiarAceite()
        {
            return "aceite cambiado ";
        }
        public string ajustarTurcas()
        {
            return "ajuantando tuercas";
        }
        public string revisarABC()
        {
            return " haciendo AbC";
        }
    }
}
