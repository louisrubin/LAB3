using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    internal class Cajero
    {
        private string direccion;
        private int nroCajero;

        static int sigNroCjro = 10;

        public Cajero(string direccion)
        {
            this.direccion = direccion;
            this.nroCajero = sigNroCjro++;  // asigno valor estatico +1 
        }


        public Usuario crearCuenta()    // retorna un usuario nuevo
        {
            string esJubilado = "";
            Usuario usuario;
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese su direccion: ");
            string direccion = Console.ReadLine();

            while (true)
            {
                Console.Write("¿Es jubilado? (si/no): ");
                esJubilado = Console.ReadLine().Trim();     // string sin espacios

                if (esJubilado.ToLower().Equals("si"))      // JUBILADO
                {
                    return usuario = new Usuario(nombre, direccion, false); 
                } else if (esJubilado.ToLower().Equals("no"))   // NO JUBILADO
                {
                    return usuario = new Usuario(nombre, direccion, true);
                } else
                {
                    Console.WriteLine("Ingrese una respuesta correcta.");
                    continue;
                }
                // todo RETORNAR CUENTA BANCARIA, YA SE CREO EL USUARIO
            }
        }

        public void deposito(Usuario usuario)
        {
            Console.Write("");
            Console.Write("Monto a depositar: $");
            double montoDeposito = double.Parse(Console.ReadLine());

            //usuario.depo
        }

        public void extraccion()
        {

        }

        public void prestamoAdelanto()
        {

        }


        // GETTERS Y SETTERS
        public string Direccion { get { return direccion; } }
        public int getNroCajero { get { return nroCajero; } }
    }

}
