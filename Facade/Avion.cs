using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Avion
    {
        public void buscarVuelos(string destino, string origen, string fechaIda, string fechaVuelta)
        {
            Console.WriteLine("===========================");
            Console.WriteLine("Vuelos encontrados para: " + destino + ". Desde: " + origen);
            Console.WriteLine("Fecha de ida: " + fechaIda + ". Fecha de vuelta" + fechaVuelta);
            Console.WriteLine("Aeroméxico BOEING511");
            Console.WriteLine("American AMEX1093");
            Console.WriteLine("===========================");
        }
    }
}
