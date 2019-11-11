using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Gasolineria
{
   public class Principal
    {     
        int c = 1; //Este es una comtador que vamos a usar mas adelante como Id
        List<Empleado> Empleados = new List<Empleado>(); //Se intancia la lista globalmente para no tener problemas para usarla en otros metodos
        public void Menu() //Metodo menu que es que nos va ayudar a interactuar con el usuario
        {
            Console.WriteLine("--BIENVENIDO A GASOLINERAS PEMEX--"); //Se le muestran las opciones disponibles al usuario
            Console.WriteLine();
            Console.WriteLine("Seleccione la opcion que desee");
            Console.WriteLine("1) Ingresar nuevo empleado al sistema");
            Console.WriteLine("2) Ver lista de empledados registrados");
            Console.WriteLine("3) Ver detalle de empleado");
            Console.WriteLine("4) SALIR");

            switch (Console.ReadLine()) //La respuesta la capturamos directamente en el switch
            {
                case "1":
                    AgregarEmpleado(); //Se manda a llamar al metodo para agregar empleados
                    Console.Clear();
                    Menu();
                    break;

                case "2":
                    VerListaEmpleados(); //Se manda llamar al metodo para mostrar la lista de empleados
                    Console.ReadKey();
                    Console.Clear();        
                    Menu();
                    break;

                case"3":
                    VerDetalleEmpleado(); // Se manda a llamar el metodo para ver un empleado y sus detalles
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;

                case "4": //Y pues aqui se cierra el programa
                    break;
                default:
                    break;
            }
        }

        public void AgregarEmpleado() //Este metodo nos va servir para agregar empleados
        {
            do
            {
                Console.Clear(); 
                Console.WriteLine("INGRESE EL NOMBRE DEL EMPLEADO: "); //Vamos ingresar datos a la lista con variables
                string nombre = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("INGRESE EL AREA DE TRABAJO: ");
                string area = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("INGRESE EL TURNO: (DIA/NOCHE) ");
                string turno = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("INGRESE FECHA DE INGRESO: (DD/MM/AAAA)");
                string fechaing = Console.ReadLine();
                Console.WriteLine();
                Empleados.Add(new Empleado { Nombre = nombre, Area = area, Turno = turno, FechaIngreso = fechaing, Id = c }); //El id me va servir para controlar a las listas de empleados 
                c++;                                                                                                          //Utilice un contador para generar automaticamente el id
                Console.WriteLine("DESEA AGREGAR OTRO EMPLEADO?  si/no"); //Utilize un do por si el usuario quiere agregar mas empleados
                 
            } while (Console.ReadLine() == "si"); //Si dice que si se repite el ciclo pero el contador cambia y crea al siguiente empleado
            
        }

        public void VerListaEmpleados() //Metodo para ver los empleados que hemos creado
        {
            Console.Clear();
            foreach (var item in Empleados) //Se utiliza un ForEach para mostrar lo que contiene las listas
            {
                Console.WriteLine("{0}.-\t{1}", item.Id, item.Nombre); //Solo se muestra el nombre y su numero de empleado
                Console.WriteLine();
            }
 
        }

        public void VerDetalleEmpleado() //Metodo para ver detalle del empleado
        {
            Console.WriteLine("Ingrese numero de empleado"); //Con el Id controlamos que empleado vamos a revisar
            int NumeroEmp = int.Parse(Console.ReadLine());
            Empleado E = new Empleado(); 
            foreach (var empleado in Empleados)
            {
                if (empleado.Id==NumeroEmp) 
                {
                    E = empleado;
                }
            }
            Console.Clear(); //Se limpia y se muestran todos los detalles del empleado
            Console.WriteLine("Numero de Empleado:\t{0}\nNombre:\t{1}\nArea:\t{2}\nTurno:\t{3}\nFecha de ingreso:\t{4}", E.Id, E.Nombre, E.Area, E.Turno, E.FechaIngreso);

        }
       
    }
}

