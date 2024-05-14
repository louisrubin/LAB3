using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas
{
    public static class Operacion
    {

        // PROGRAMA PARA OBTENER EL FACTORIAL DE UN NUMERO INGRESADO POR CONSOLA
        public static int factorial(int num)
        {
            if (num == 1)
            {
                return num;
            }
            return num * factorial(num - 1);
        }


        // PROGRAMA PARA OBTENER TABLA DE MULTIPLICAR DE UN NUMERO INGRESADO POR CONSOLA
        public static int tablaMult(int num, int mult = 1)
        {
            //int mult = num2;
            if (mult == 11)
            {
                return mult;
            }
            Console.WriteLine($"{num}x{mult} = {num * mult}");

            return tablaMult(num, mult + 1);
        }
    }
}
