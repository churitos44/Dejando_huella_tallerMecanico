using System;
using System.Collections.Generic;
using System.Text;

namespace Taller
{
    class Cliente:Persona
    {
      
      
        public  int Edad { get; set; }

        public string Saludar()
        {
            return $"Hola soy  {Nombre}  necesito ayuda con mi auto ";
        }

        public string dañoDelCarro()
        {
            return $" Bueno   mi auto   tine problemas con los frenos  tuve un accidente que casi choco ";
        }
        public string Probar()
        {
            return $"mi carro quedo muy bien  gracias por su ayuda  ¡";
        }

        static string Cancelar()
        {
            return $"listo esta cancelado todo  ";
        }

    }
}
