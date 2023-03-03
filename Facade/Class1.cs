using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Fachada
    {
        private Avion PlaneApi;
        private Hotel HotelApi;

        public Fachada()
        {
            PlaneApi = new Avion();
            HotelApi = new Hotel();
        }

        public void buscar(string fechaIda, string fechaLlegada, string origen, string destino)
        {
            PlaneApi.buscarVuelos(fechaIda, fechaLlegada, origen, destino);
            HotelApi.buscarHotel(fechaIda, fechaLlegada, origen, destino);
        }
    }
}
