using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            //List <string> paises = new List <string>()
            //{

            //    "Francia","Holanda", "Inglaterra", "Polonia"

            //};

            //paises.Add("Italia");
            //paises.Insert(8, "Austria");
            //paises.RemoveAt(3);
            //paises.Remove("Holanda");
            ////paises[2]; // Te da una posicion determinada

            //int posicion = paises.IndexOf("Francia"); // Te busca la primera coincidencia del string . En este caso Francia. Si no encuentra -1


            //// Recorrer una lista . Normalmente con un For

            //for (int i = 0; i < paises.Count; i++)
            //{

            //    Console.WriteLine(paises[i]);
            //}


            // BUCLE FOREACH

            // Por cada elemento en la lista de paises {haz esto}. Recorre toda la lista . NO PERSONALIZABLE

            //foreach (string elemento in paises)
            //{
            //    Console.WriteLine(elemento);
            //}


            //// SE PUEDEN HACER LOS OBJETOS DENTRO DE LA LISTA

            

            //List<Paises> paises = new List<Paises>()
            //{
            //    new Paises("Francia", "Paris", 20000000);
            //  new Paises("Italia", "Roma", 100000);
            // new Paises("Portugal", "Lisboa", 120000);

            // };

            Paises p1 = new Paises("Francia", "Paris", 20000000);
            Paises p2 = new Paises("Italia", "Roma", 100000);
            Paises p3 = new Paises("Portugal", "Lisboa", 120000);

            List<Paises> paises = new List<Paises>()
            {
                p1,p2,p3

            };

            foreach(Paises pais in paises)
            {

                Console.WriteLine(pais.Capital);
            }




        }
    }
}
