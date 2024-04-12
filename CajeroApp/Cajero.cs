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

        private CuentaBancaria cuentaBancaria;
        private DateTime diaActual = DateTime.Today;    // dia actual en cajero

        //private List<CuentaBancaria> cuentaBancarias = new List<CuentaBancaria>();

        static int sigNroCjro = 10;

        public Cajero(string direccion)
        {
            this.direccion = direccion;
            this.nroCajero = sigNroCjro++;  // asigno valor estatico +1 
        }


        public void crearCuenta()    // retorna un usuario nuevo
        {
            if (cuentaBancaria == null)     // si no existe una cuenta bancaria
            {
                string esJubilado = "";
                Usuario usuarioNuevo;
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
                        usuarioNuevo = new Usuario(nombre, direccion, false);
                        break;
                    }
                    else if (esJubilado.ToLower().Equals("no"))   // NO ES JUBILADO
                    {
                        usuarioNuevo = new Usuario(nombre, direccion, true);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ingrese una respuesta correcta.");
                        continue;
                    }
                }
                cuentaBancaria = new CuentaBancaria(usuarioNuevo);
                Console.WriteLine("Cuenta Bancaria creada.");
            }
            else Console.WriteLine("Ya existe una cuenta bancaria.");

        }

        public void deposito()
        {
            if(cuentaBancaria != null)      // cuenta bancaria existe
            {
                Console.Write("Monto a depositar: $");
                double montoDeposito;
                double.TryParse(Console.ReadLine(), out montoDeposito);
                this.cuentaBancaria.deposito(montoDeposito);
            } else Console.WriteLine("No existe una Cuenta Bancaria.");
            
        }

        public void extraccion()
        {
            if (cuentaBancaria != null)      // cuenta bancaria existe
            {
                Console.Write("Monto a extraer: $");
                double montoExtraccion;
                double.TryParse(Console.ReadLine(), out montoExtraccion);
                this.cuentaBancaria.extraccion(montoExtraccion);
            }
            else Console.WriteLine("No existe una Cuenta Bancaria.");
        }

        public void prestamoAdelanto()
        {

        }

        public void aumentarMeses(byte cantMeses=2) // aumenta cant de meses (por default: 2)
        {
            diaActual = diaActual.AddMonths(cantMeses);
        }


        // GETTERS Y SETTERS
        public DateTime getDiaActual { get { return diaActual;  } }
        public string Direccion { get { return direccion; } }
        public int getNroCajero { get { return nroCajero; } }
    }

}
