using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Gasolineria
{
   public class Empleado //Se crean los atributos del empleado
    {
        //Pues hice la mayoria strig para trabajar sin problemas
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Area { get; set; }
        public string Turno { get; set; }
        public string FechaIngreso { get; set; } //No utlice datatime porque estoy bien menso y luego tengo pedos para imprimirlo o asi
                                                 //Aunque siento que hubiera sido lo correcto ya que el registro tiene que quedar con la fecha del dia
    }
}
