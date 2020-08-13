using System;
using System.Collections.Generic;
using System.Text;

namespace Taller
{
    class GeneradorAutomaticoIdentificador
    {
        readonly Random random = new Random();
        public int Id { get; set; }
        public GeneradorAutomaticoIdentificador()
        {
            Id = random.Next();
        }
    }
}
