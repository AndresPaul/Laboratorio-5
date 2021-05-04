using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Strategy.Core
{
    public class Fanta : Refresco
    {
        public override string Dispensar()
        {
            return "Obteniendo una FANTA";
        }
    }
}
