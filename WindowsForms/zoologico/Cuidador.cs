using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsForms
{
    public class persona {
        public string nombre { get; set; }

        public persona()
        {
           this.nombre = "Pedro";
        }

        public persona(string nombre)
        {
            this.nombre = nombre;
        }
    }

    public class Cuidador : persona
    {
        private int legajo { get; set; }
        public static int sigLeg = 100;
        public Cuidador()
            : base()
        {
            this.legajo = ++sigLeg;
        }
        public Cuidador(string nombre)
            : base(nombre)
        {
            this.legajo = ++sigLeg;
        }

        public void alimentar(List<Animal> ListaAnimales)
        {
            Console.WriteLine("{0} es el cuidador, su legajo es:{1}",this.nombre,this.legajo);
            foreach (var item in ListaAnimales)
            {
                Console.WriteLine("El {0} come {1}",item.nombre,item.comida);
            }
        }

        public int getLegajo()
        {
            return this.legajo;
        }
    }
}
