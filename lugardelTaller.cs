using System;
using System.Collections.Generic;
using System.Text;

namespace Taller
{
    abstract class lugardelTaller:GeneradorAutomaticoIdentificador
    {
        public lugardelTaller(string nombre, string telefono, string direccion) 
        {
            Nombre = nombre;
            Telefono = telefono;
            Direccion = direccion;
        }

        public String Nombre { get; set; }
        public String Telefono { get; set; }
        public String Direccion { get; set; }


        public virtual string Sucursal()
        {
            return $" sucursal nueva en chillos";
        }
    }
}
