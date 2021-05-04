using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Strategy.Core
{
    public class Dispensador
    {
        Refresco _estrategia;
        public void CambiarEstrategia(Refresco estrategia)
        {
            if (estrategia == null) throw new Exception("No puede ser null");
            _estrategia = estrategia;
        }

        public string Nombre { get; set; }

        public string Dispensar()
        {
            if (_estrategia == null) return "Refresco no disponible";
            return _estrategia.Dispensar();
        }
    }
}
