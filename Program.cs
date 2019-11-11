using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Gasolineria
{
    class Program
    {
        static void Main(string[] args)
        {
            Principal PR = new Principal(); //Se intancia la clase Principal
            PR.Menu(); //Se manda a llamar el metodo menu que es el que jala todo
        }
    }
}
