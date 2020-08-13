using System;
using System.Collections.Generic;
using System.Text;

namespace Mecanicos.Interfaz
{
    interface IMecanico
    {
        public string repararMotor();

        public string cambiarFrenos();

        public string cambiarAceite();

        public string ajustarTurcas();

        public string revisarABC();
    }
}
