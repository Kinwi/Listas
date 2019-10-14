using System;
using System.Collections.Generic;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)


        {


            List<string> deportes = new List<string>();

            deportes = CrearLista(deportes);

            OrdenarLista(deportes);

            ContarElementos(deportes);
            BorrarDeLaLista("elemento",deportes);


        }


        public static List<string> CrearLista(List<string> deportes)
        {


            {
                deportes.Add("Futbol");
                deportes.Add("Baloncesto");
                deportes.Add("Tenis");
                return deportes;
            }

        }

        public static  void MostrarLista(List<string> deportes)

        {
            for (int i = 0; i < deportes.Count; i++)
            {
                Console.WriteLine(deportes[i]);
            }

        }

        public static void OrdenarLista(List<string> deportes)
        {
            deportes.Sort();
            MostrarLista(deportes);
        }


        public static void BorrarDeLaLista(string elemento,List<string> deportes)
        {

            if (deportes.Remove(elemento))
            {
                Console.WriteLine("Se ha conseguido borrar el elemento");
            }

            else
            {
                Console.WriteLine("El elemeto no ha sido elminado");
            }
            
        }

        public static int ContarElementos(List<string> deportes)
        {
            int contador =0;

            for (int i = 0; i < deportes.Count; i++)
            {
                contador ++;
            }

            return contador;
        }

    }
}
    

