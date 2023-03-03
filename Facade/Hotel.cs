using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Hotel
    {
        public void buscarHotel(string fechaIn, string fechaOut, string origen, string des)
        {
            Console.WriteLine("===========================");
            Console.WriteLine("Hoteles encontrados...");
            Console.WriteLine("Entrada: " + fechaIn + ". Salida: " + fechaOut);
            Console.WriteLine("Hotel trivago");
            Console.WriteLine("Hotel Continental");
            Console.WriteLine("Hotel California");
            Console.WriteLine("===========================");
        }
    }
}
