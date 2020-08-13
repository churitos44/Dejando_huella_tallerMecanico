using System;
using System.Collections.Generic;
using System.Text;

namespace Taller
{
    class Repuesto:GeneradorAutomaticoIdentificador
    {
    
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public int cantidad { get; set; }
        public int Precio { get; set; }



        public string MisRepuestops()
        {
            return $" repuestos de todo tipo  con calidad garantizada";
        }
        public string informacionRepuesto ()
        {
            return $"  {Nombre}   la marca  con la que trabajos es : {Marca}  su  precio es :  {Precio}";
        }
        public string comprar()
        {
            return $"   la cantidad de producto es:{cantidad} su  precio es :  {Precio} dolares  ";
        }
      


    }


}
