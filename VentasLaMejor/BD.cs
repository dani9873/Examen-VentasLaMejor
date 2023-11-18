using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libreriaIEACLA;

namespace VentasLaMejor
{
    class BD
    {
        public static AccesoADatos conexion = new AccesoADatos("bdVentasLaMejor");
    }
}
