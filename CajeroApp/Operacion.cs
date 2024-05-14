using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class Operacion
    {
        private int idOperacion;
        private DateTime fechaOperac;
        private Cajero cajero;
        private string tipoOperacion;
        private double monto;
        private double nuevoSaldo;      // nuevo saldo 

        static int sigID = 10000;

        public Operacion(DateTime fechaOperac, Cajero cajero, string tipoOperacion, double monto, double nuevoSaldo)
        {
            this.idOperacion = sigID++;
            this.fechaOperac = fechaOperac;
            this.cajero = cajero;
            this.tipoOperacion = tipoOperacion;
            this.monto = monto;
            this.nuevoSaldo = nuevoSaldo;
        }

        public void toString()
        {
            Console.WriteLine($"ID Operacion: {idOperacion}, " +
                $"Fecha: {fechaOperac.ToString("dd/MM/yyyy")}, " +
                $"CajeroNro: {cajero.getNroCajero}, Operacion: {tipoOperacion}, " +
                $"Monto: ${monto}");
        }


        // GETTERS
        public double getNuevoSaldo { get { return nuevoSaldo; } }
        public DateTime getFechaOperacion { get { return fechaOperac;  } }
        public Cajero getCajero { get { return cajero; } }
        public string getTipoOperacion { get { return tipoOperacion; } }
        public double getMontoOperacion { get { return monto; } }
    }
}
