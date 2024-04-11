using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class CuentaBancaria
    {
        private int nroCuenta;
        private double saldoActual = 0;
        private DateTime fechaApertura, ultimoAdelanto;
        private Usuario usuario;        // relacion --> clase Usuario
        private double maxSaldoNegat;   // maximo de extraccion en negativo
        
        //private int adelantoCada = 15;  // días para adelanto de plata 

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
        public double deposito { set { this.saldoActual += value; } }
        public double extraccion
        {
            set
            {
                if (value > saldoActual + maxSaldoNegat)    // formula 
                {
                    Console.WriteLine("Saldo insuficiente.");
                }
                else
                {
                    this.saldoActual -= value;  // efectua la extraccion
                }
            }
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
        public int getNroCuenta { get { return nroCuenta; } }
        public double getSaldoActual { get { return saldoActual; } }
        public DateTime getFechaApertura { get { return fechaApertura; } }
        public DateTime setFechaApertura { set { this.fechaApertura = value; } }
        public Usuario getUsuario { get { return usuario; } }
        public double setMaxSaldoNegat { set { this.maxSaldoNegat = value;} }
    }
}
