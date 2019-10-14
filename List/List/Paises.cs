using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    class Paises
    {

        public string Nombre{ get; set; }
        public string Capital { get; set; }

        public int Poblacion { get; set; }



        public Paises(string nombre, string capital, int poblacion)
        {
            Nombre = nombre;
            Capital = capital;
            Poblacion = poblacion;
        }
    }
}
