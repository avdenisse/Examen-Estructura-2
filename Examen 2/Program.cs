using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Examen_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiantes es = new Estudiantes();
            es.matriz();
            int opcion;
            do
            {  
                Console.Clear();
                Console.WriteLine("***************MENU**************");
                Console.WriteLine("1. Ingresar Nombres");
                Console.WriteLine("2. Ingresar Carnet");
                Console.WriteLine("3. Ingresar Notas");
                Console.WriteLine("4. Calcular Promedio");
                Console.WriteLine("5. Imprimir");
                Console.WriteLine("6. Salir");
                Console.WriteLine();
                Console.Write("Ingrese su opcion: ");
                opcion = int.Parse(Console.ReadLine());
                
                switch (opcion)
                {
                    case 1:
                        es.ingresarNombres();
                        break;
                    case 2:
                        es.ingresarCarnet();
                        break;
                    case 3:
                        es.ingresarNotas();
                        break;
                    case 4:
                        es.calcularPromedio();
                        break;
                    case 5:
                        es.imprimir();
                        break;


                }
                Console.ReadKey();

            } while (opcion != 6);
                  
        }
    }
}
