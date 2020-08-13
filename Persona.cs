using System;
using System.Collections.Generic;
using System.Text;

namespace Taller
{
    abstract class Persona : GeneradorAutomaticoIdentificador
    {

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }

        public virtual string Conversar()
        {
            return $"hola que tal alos años amigo cuanto tiempo sin verte";
        }
    }
}


