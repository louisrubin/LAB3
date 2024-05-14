using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class Cajero
    {
        private string direccion;
        private int nroCajero;

        private CuentaBancaria cuentaBancaria;
        private DateTime fechaActual = DateTime.Today;    // dia actual en cajero

        private bool obtuvoCredito = false;

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
                this.cuentaBancaria.deposito(montoDeposito, this , fechaActual);
            } else Console.WriteLine("No existe una Cuenta Bancaria.");
            
        }

        public void extraccion()
        {
            if (cuentaBancaria != null)      // cuenta bancaria existe
            {
                Console.Write("Monto a extraer: $");
                double montoExtraccion;
                double.TryParse(Console.ReadLine(), out montoExtraccion);
                this.cuentaBancaria.extraccion(montoExtraccion, this, fechaActual);
            }
            else Console.WriteLine("No existe una Cuenta Bancaria.");
        }

        public bool ofrecerCredito( )
        {
            if (cuentaBancaria != null && obtuvoCredito==false)     // mientras exista una cuenta Bancaria
            {
                List<Operacion> listOperaciones = cuentaBancaria.getOperaciones;

                foreach (Operacion oper in Enumerable.Reverse(listOperaciones))  // Enumerable.Reverse() recorre la lista en reversa
                {
                    // nuevo saldo desp. de operacion >= 20000 y hay una diferencia de 60 días
                    if (oper.getNuevoSaldo >= 20000 && 
                        ( Math.Abs( (fechaActual - oper.getFechaOperacion).Days )) >= 60 ) {
                        cuentaBancaria.setMaxSaldoNegat = 80000;
                        obtuvoCredito = true;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\t¡Felicidades haz obtenido un crédito! \n\t¡Ahora puede extraer hasta $80.000!");
                        Console.ResetColor();

                        return true;     
                    }
                }
            }
            return false;
        }
        public void verMovimientos()
        {
            if (cuentaBancaria != null) cuentaBancaria.verMovimientos();
            else Console.WriteLine("No existe una Cuenta Bancaria.");
        }

        public void aumentarDias(byte cantDias = 15) // aumenta cant de dias (por default = )
        {
            fechaActual = fechaActual.AddDays(cantDias);
        }

        public void toString()
        {
            Console.WriteLine($"NRO Cajero: {nroCajero}, Direccion: {direccion}");
        }


        // GETTERS Y SETTERS
        public double getSaldoActual { 
            get {
                if (cuentaBancaria != null) return cuentaBancaria.getSaldoActual;
                else return 0; 
            } }
        public CuentaBancaria getCuentaBancaria => this.cuentaBancaria; // C# 6 o posterior (return cuentaBancaria)
        public DateTime getDiaActual { get { return fechaActual;  } }
        public string Direccion { get { return direccion; } }
        public int getNroCajero { get { return nroCajero; } }
    }

}
