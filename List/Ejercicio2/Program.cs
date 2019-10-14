using System;
using System.Collections.Generic;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            //2.Lee por consola los números que introduzca el usuario. 
            //Si el número introducido es decimal lo guardará en una lista de números decimales,.
            //Si no es decimal entonces los guardará en una lista de ints.


            //El programa seguirá pidiendo al usuario que introduzca números hasta que introduzca un número negativo.Una vez haya introducido un número negativo:
            //Muestra cuántos números decimales y cuantos enteros ha creado.
            //Haz la suma de todos los números enteros introducidos.
            //Saca la media de todos los números, tanto enteros como decimales JUNTOS.
            //Controla las posibles excepciones que se puedan dar, como por ejemplo introducir una letra en una variable double.

            double deci = 0;
            int entero = 0;
            int suma = 0;
            double media = 0;
            List<int> enteros = new List<int>();
            List<double> decimales = new List<double>();


            do
            {

                Console.WriteLine("Introduzca numeros por consola");
                string numero = Console.ReadLine();

                if (Int32.TryParse(numero, out entero))
                {

                    if (entero >= 0)
                    {
                        media += 0;
                        suma += 0;
                        enteros.Add(entero);
                    }
                }

                else if (Double.TryParse(numero, out deci))
                {
                    if (deci >= 0)
                    {
                        media += 0;

                        decimales.Add(deci);
                    }

                }

                else
                {
                    Console.WriteLine("Introduce un numero correcto");
                }

            } while (deci >= 0 && entero >= 0);



            foreach (int ent in enteros)
            {
                Console.Write(ent + " ");
            }
            Console.WriteLine();

            foreach (double dec in decimales)
            {
                Console.Write(dec + " ");
            }

            Console.WriteLine($"La suma de todos los valores enteros es :{suma}");
            Console.WriteLine($"La media de todos los valores:"{ media/ (enteros.Count + decimales.Count)};
        }
}   }

