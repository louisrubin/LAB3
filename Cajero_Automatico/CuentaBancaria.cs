using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero_Automatico
{
    public class CuentaBancaria
    {
        private int nroCuenta;
        private double saldoActual = 0;
        private DateTime fechaApertura;
        private Usuario usuario;        // relacion --> clase Usuario
        private double maxSaldoNegat;   // maximo de extraccion en negativo

        private List<Operacion> operacions = new List<Operacion>();

        static int sigNroCuenta = 1000;     // variable estatica para asignar nroCuenta

        // CONSTRUCTORES
        public CuentaBancaria(Usuario usuario)
        {
            this.nroCuenta = sigNroCuenta++;
            this.fechaApertura = DateTime.Today;    // automatico
            this.usuario = usuario;
            this.maxSaldoNegat = (usuario.getEnActividad) ? this.maxSaldoNegat = 20000 : this.maxSaldoNegat = 10000;
        }
        public CuentaBancaria(Usuario usuario, double saldo)
        {
            this.nroCuenta = sigNroCuenta++;
            this.saldoActual = saldo;
            this.fechaApertura = DateTime.Today;    // automatico
            this.usuario = usuario;
            this.maxSaldoNegat = (usuario.getEnActividad) ? this.maxSaldoNegat = 20000 : this.maxSaldoNegat = 10000;
        }

        public CuentaBancaria(Usuario usuario, double saldo, DateTime fechaCreacion)
        {
            this.nroCuenta = sigNroCuenta++;
            this.saldoActual = saldo;
            this.usuario = usuario;
            this.fechaApertura = fechaCreacion;     // fecha especifica
            this.maxSaldoNegat = (usuario.getEnActividad) ? this.maxSaldoNegat = 20000 : this.maxSaldoNegat = 10000;
        }

        public CuentaBancaria(double saldo, DateTime fechaCreacion, Usuario username)
        {
            this.nroCuenta = sigNroCuenta++;
            this.saldoActual = saldo;
            this.fechaApertura = fechaCreacion;
            this.usuario = username;
            this.maxSaldoNegat = (usuario.getEnActividad) ? this.maxSaldoNegat = 20000 : this.maxSaldoNegat = 10000;

        }

        // METODOS
        public void deposito(double montoDepositar, Cajero cajero, DateTime fechaOperacion)
        {
            try
            {
                string tipoOperacion = "DEPOSITO";
                this.saldoActual += montoDepositar;
                // agrego a la List de Operaciones
                this.operacions.Add(new Operacion(fechaOperacion, cajero, tipoOperacion, montoDepositar, saldoActual));
                Console.WriteLine("Deposito exitoso.");
            }
            catch
            {
                Console.WriteLine("Hubo un error en el depósito.");
            }

        }
        public void extraccion(double montoExtraer, Cajero cajero, DateTime fechaOperacion)
        {
            try
            {
                if (montoExtraer > saldoActual + maxSaldoNegat)    // formula 
                {
                    Console.WriteLine("Saldo insuficiente.");
                }
                else
                {
                    string tipoOperacion = "EXTRACCION";
                    this.saldoActual -= montoExtraer;  // efectua la extraccion
                    this.operacions.Add(new Operacion(fechaOperacion, cajero, tipoOperacion, montoExtraer, saldoActual));
                    Console.WriteLine("Extracción exitosa.");
                }
            }
            catch
            {
                Console.WriteLine("Hubo un error en la extracción.");
            }
        }


        public void verMovimientos()
        {
            Console.WriteLine("LISTA DE MOVIMIENTOS: ");
            if (operacions.Count > 0)
            {
                foreach (Operacion oper in this.operacions)
                {
                    oper.toString();
                }
            }
            else Console.WriteLine("\tSin Movimientos.");
        }

        // ADELANTO TENIENDO EN CUENTA LA FECHA DEL ULTIMO ADELANTO.
        //public double adelanto
        //{
        //    set
        //    {
        //        if (this.ultimoAdelanto == null)    // si pasaron 30 dias desde el ult adelanto
        //        {
        //            this.ultimoAdelanto = DateTime.Today;
        //            if (usuario.getEnActividad) this.saldoActual += 20000;
        //            else this.saldoActual += 10000;
        //        }

        //        if (puedeAdelanto(this.ultimoAdelanto))     // SI PASARON 30 DIAS
        //        {
        //            if (usuario.getEnActividad) this.saldoActual += 20000;
        //            else this.saldoActual += 10000;
        //            Console.WriteLine("Se acredito el adelanto.");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"Deben pasar {adelantoCada} dias desde el ultimo adelanto.");
        //        }
        //    }
        //}

        // METODO PARA SABER SI PASO 30 DIAS DESDE EL ULTIMO ADELANTO
        //private bool puedeAdelanto(DateTime ultimoAdelanto)
        //{
        //    DateTime fechaHoy = DateTime.Today;             // obtenemos la fecha de hoy
        //    TimeSpan diferenciaDays = fechaHoy - ultimoAdelanto;   // diferencia entre dias en formato Date

        //    int diferenEntero = Math.Abs(diferenciaDays.Days);      // obtengo la diferencia en numero.

        //    if (diferenEntero >= this.adelantoCada)    // si la diferencia en Entero es mayor o igual a 30 días
        //    {
        //        return true;
        //    }

        //    return false;
        //}


        // GETTERS Y SETTER
        public List<Operacion> getOperaciones => operacions; // C# 6 o posterior (return operacions)
        public int getNroCuenta => nroCuenta;
        public double getSaldoActual { get { return saldoActual; } }
        public DateTime getFechaApertura { get { return fechaApertura; } }
        public DateTime setFechaApertura { set { this.fechaApertura = value; } }
        public Usuario getUsuario { get { return usuario; } }
        public double setMaxSaldoNegat { set { this.maxSaldoNegat = value; } }
    }
}
