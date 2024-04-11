using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class Usuario
    {
        private int id;
        private string nombre, direccion;
        private bool enActividad;   // si no esta en actividad --> jubilado

        static int sigId = 100;     // variable estatica para asignar ID

        //public Usuario()
        //{
        //    this.id = sigId++;
        //}

        public Usuario(string nombre, bool enActiv)
        {
            this.id = sigId++;
            this.nombre = nombre;
            this.enActividad = enActiv;
        }

        public Usuario(string nombre, string direccion, bool enActiv)
        {
            this.id = sigId++;
            this.nombre = nombre;
            this.direccion = direccion;
            this.enActividad = enActiv;
        }

        // GETers
        public int getId { get { return id; } }
        public string getNombre { get { return nombre; } }
        public string getDireccion { get { return direccion; } }
        public bool getEnActividad { get { return enActividad; } }
    }
}
