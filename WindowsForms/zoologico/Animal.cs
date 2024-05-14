using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace WindowsForms
{
    interface IAnimal
    { void comer();
      void presentarse();
    }


    public class Animal: IAnimal
    {
        public int legajo {  get; set; }
        public string nombre { get; set; }
        public string especie { get; set; }
        public string comida { get; set; }

        public static int sigLegajo = 100;
        public Animal(string nombre,string especie,string comida)
        {
            this.legajo = ++sigLegajo;
            this.nombre = nombre;
            this.especie = especie;
            this.comida = comida;
            Console.WriteLine("Animal creado, legajo: "+ legajo);
        }

        virtual public void comer()
        {
            Console.WriteLine("{0}",this.comida);
        }
        virtual public void presentarse()
        {
            Console.WriteLine("{0}",this.nombre);

        }
    }

    class mamifero:Animal
    {
        public mamifero(string n,string e,string c)
            :base(n,e,c)
        {

        }
        public void Amamantar()
        {
            Console.WriteLine("{0} puede amamantar",this.nombre);
        }

        public override void presentarse()
        {
            this.Amamantar();
        }
    }

    class ave : Animal
    {
        public ave(string n, string e, string c)
              : base(n, e, c)
        {

        }

        public override void presentarse()
        {
            this.Volar();
        }

        public void Volar()
        {
            Console.WriteLine("{0} vuela como un ave",this.nombre);
        }

    }

    class pez :Animal
    {
        public pez(string n, string e, string c)
            : base(n, e, c)
        {

        }

        public override void presentarse()
        {
            this.Nadar();
        }
        public void Nadar()
        {
            Console.WriteLine("{0} nada como un pez",this.nombre);
        }
    }

    class PlantaCarnivora : Animal
    {
        public PlantaCarnivora(string name, string espec, string comida)
            : base(name, espec, comida)     // constructor padre
        {
        }

        public override void presentarse()
        {
            Console.WriteLine("hola soy una planta carnivora: "+ this.nombre);
        }
        public override void comer()
        {
            Console.WriteLine("me alimento de: " + this.nombre + "(s)");
        }
    }

}
