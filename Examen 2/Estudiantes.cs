using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_2
{
    internal class Estudiantes
    {
        /// DECLARACION DE VARIABLES///
        string[] nombreApellido = new string[4];
        string[] carnetEs = new string[4];
        int filas;
        int iNom;
        int iCarn;
        int columnas;
        int[,] notas;
        int[] promedioG = new int[4];
        float promedio;
        int cont= 0; /*El cont es para poder asignar las notas de cada 
                      * estudiante en la fila correspondiente*/



        ///DECLARACIÓN DE FUNCIONES///
        
        public void matriz()
        {
            this.filas = 4;
            this.columnas = 3;
            this.notas = new int[this.filas, this.columnas];
        }

        public void ingresarNombres()
        {
            string nombres;
            Console.Write("Ingrese el nombre y apellido del estudiante: ");
            nombres = Console.ReadLine();
            nombreApellido[this.iNom] = nombres;
            this.iNom++;
        }


        public void ingresarCarnet()
        {
            string carnet;
            Console.Write("Ingrese el carnet del estudiante; ");
            carnet = Console.ReadLine();
            carnetEs[this.iCarn] = carnet;
            this.iCarn++;
            
            
        }

        public void ingresarNotas()
        {
            
            for (int j = 0; j < columnas; j++)
            {
                Console.Write($"Ingrese la nota: ");
                this.notas[cont, j] = int.Parse(Console.ReadLine()); 
           
            }
            this.cont++;
         }
           
        

        public float calcularPromedio()
        {
            string nombre;
            int indice;
            Console.Write("Ingrese el nombre del estudiante que desea calcular promedio: ");
            nombre = Console.ReadLine();
            indice = Array.IndexOf(nombreApellido, nombre);
            promedio = (notas[indice, 0] + notas[indice,1] + notas[indice, 2]) / 3;
            promedio = promedioG[indice];
            return promedio;
            
        }

        public void imprimir()
        {
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("| Carné   | Nombre completo    | Nota1 | Nota2 | Nota3 | Promedio |");
            Console.WriteLine("-------------------------------------------------------------");

            for (int i = 0; i < filas; i++)
            {
                float promedio = (notas[i, 0] + notas[i, 1] + notas[i, 2]) / 3.0f;

                Console.WriteLine(
                    $"| {carnetEs[i],-7} | {nombreApellido[i],-18} | {notas[i, 0],5} | {notas[i, 1],5} | {notas[i, 2],5} | {promedio,8:F2} |"
                );
            }

            Console.WriteLine("-------------------------------------------------------------");
        }

    }
}
