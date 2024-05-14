using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas
{
    internal class OperacFecha
    {

        /* 3.Realice un programa que solicite cuál fue el primer día del mes, por ejemplo el primer día del mes 
        de marzo de 2022 fue un martes. Luego con esta información el sistema debe poder calcular que día será, 
        el correspondiente a una fecha dada. Por lo cual el sistema podría preguntar, ingrese una fecha del 
        mes de marzo y le diré que día cae. */

        void ingresarNum(out int num)
        {
            Console.Write("Ingrese nro: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------");
        }

        void ingresarFecha(out int mes)
        {
            Console.Write("Ingrese MES (nro): ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------");
        }
        void ingresarFecha(out int mes, out int dia)
        {
            Console.Write("Ingrese MES (nro): ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------");
            Console.Write("Ingrese DIA (nro): ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------");
        }

        public DateTime queDiaSera()
        {
            //DateTime time = new DateTime(2024, numIngr, 01);

            int numIngr, dia;
            ingresarFecha(out numIngr, out dia);     // la funcion me asigna el valor a "numIngr"

            //Console.Write("Ingrese dia (nro): ");
            //dia = int.Parse(Console.ReadLine());

            DateTime fecha = new DateTime(2024, numIngr, dia);

            Console.WriteLine("Dia: " + fecha.DayOfWeek);
            return fecha;
        }




        /* 4.Realice un programa que solicite el primer día de cada uno de los doce 
        meses del año. Con esta información podrá pedir al sistema que dada una 
        determinada fecha el mismo le indique que día será. El sistema también 
        podrá responder al requerimiento que fechas caen los fines de semana de 
        un determinado mes.
         */

        public void diaYFindes()
        {

            Console.WriteLine("\tQue dia será.\n");
            DateTime fechaReturn = queDiaSera();    // ejecuta el programa anterior

            Console.WriteLine("\n\n\tFines de semana.\n");
            int numIngr;
            ingresarFecha(out numIngr);     // la funcion me asigna el valor a "numIngr"
            DateTime fecha = new DateTime(fechaReturn.Year, fechaReturn.Month, 01);

            int cantDias = DateTime.DaysInMonth(fechaReturn.Year, numIngr);

            Console.WriteLine("\n------------------------------------\nFINES DE SEMANA:");

            for (int x = 1; x <= cantDias; x++)
            {
                if (fecha.DayOfWeek == DayOfWeek.Sunday || fecha.DayOfWeek == DayOfWeek.Saturday)
                {
                    Console.Write(fecha.Day + ", ");        // si es sabado o domingo imprime
                }
                fecha = fecha.AddDays(1);       // aumenta en 1 dias la fecha
            }
            Console.WriteLine(" ");
        }

        //Console.ReadLine();




        /*
           5. Se agrega el nuevo requerimiento al sistema de fechas. 
            Se espera que pueda arrojar el monto de un presupuesto para 
            desarrollo considerando la siguiente información. La hora de 
            desarrollo será de $3000, el programador trabajará 4 horas por 
            día en el proyecto. Él estimo terminar con la incidencia 10 días 
            habiles, comenzando el 8 de abril de 2022.
        */

        public void montoPresupuesto()
        {
            const double montoHora = 3000;
            double montoTotal = 0;
            byte diasTrabajados = 0;
            byte diasPorTrabajar = 10;
            DateTime fecha = new DateTime(2022, 04, 08);    // fecha

            while (diasTrabajados < diasPorTrabajar)
            {
                if (fecha.DayOfWeek != DayOfWeek.Saturday && fecha.DayOfWeek != DayOfWeek.Sunday)
                {
                    montoTotal += montoHora * 4;
                    diasTrabajados++;
                }

                if (diasTrabajados < 10)
                {
                    fecha = fecha.AddDays(1);
                }
            }

            Console.WriteLine($"TOTAL PRESUPUESTO: ${montoTotal}");
            Console.WriteLine($"Dia final: {fecha.Day}/{fecha.Month}" +
                $"\nDías trabajados: {diasTrabajados}");
        }

    }
}
