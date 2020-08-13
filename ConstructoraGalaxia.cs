using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Mecanicos.Interfaz
{
    class ConstructoraGalaxia
    {
        public IMecanico Mecanico { get; set; }
        public string ContratarMecanico(IMecanico mecanico)
        {
            Mecanico = mecanico;
            return "contrate un mecanico";
        }
        public string RepararCarro()
        {
           return Mecanico.repararMotor() + "carro";
        }

        public string ContratarMecanico()
        {
            Mecanico = new Mecanico();
            return "contrate un mecanico";
        }
        public string ContratarMecanicoDeMoto()
        {
            Mecanico= new MecanicoDeMoto();
            return "contrate un mecanico de moto";
        }
        public string ContratarMecanicoDeTractor()
        {
            Mecanico = new MecanicoDeTractor();
            return "contrate un mecanico";
        }


    }
}
