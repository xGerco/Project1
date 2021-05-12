using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_escuela
{
    class B4:datos
    {
        public decimal calcular(decimal pnota, decimal snota, decimal tnota, decimal cnota)
        {
            decimal prom = pnota + snota + tnota + cnota;
            return prom;
        }
    }
}
