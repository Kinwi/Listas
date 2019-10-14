using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List <string> paises = new List <string>()
            {

                "Francia","Holanda", "Inglaterra", "Polonia"

            };

            paises.Add("Italia");
            paises.Insert(8, "Austria");
            paises.RemoveAt(3);
            paises.Remove("Holanda");
            //paises[2]; // Te da una posicion determinada

            int posicion = paises.IndexOf("Francia"); // Te busca la primera coincidencia del string . En este caso Francia. Si no encuentra -1


            // Recorrer una lista . Normalmente con un For

            for (int i = 0; i < paises.Count; i++)
            {

                Console.WriteLine(paises[i]);
            }


            // BUCLE FOREACH

            // Por cada elemento en la lista de paises {haz esto}. Recorre toda la lista . NO PERSONALIZABLE

            foreach (string elemento in paises)
            {
                Console.WriteLine(elemento);
            }

           

        }
    }
}
