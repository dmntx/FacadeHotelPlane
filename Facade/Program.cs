using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Fachada app1 = new Fachada();
            Fachada app2 = new Fachada();
            app1.buscar("12/03/2023", "14/03/2023", "Puebla", "Cancun");
            app2.buscar("23/11/2023", "24/12/2023", "Puebla", "Los Angeles");
            Console.ReadKey();
        }
    }
}
