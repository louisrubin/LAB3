using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    internal class Menu
    {
        private static Cajero cajero1 = new Cajero("Av. Hernandarias 750");    // cajero ya creado
        public static void main()
        {

            while (true)
            {
                Console.WriteLine($"{cajero1.getDiaActual.ToString("dd/MM/yyyy")}\nMENU:");
                while (true)
                {
                    Console.Write("1- Crear cuenta bancaria\n2- Deposito\n3- Extraccion\n --> ");
                    int opc;
                    if (int.TryParse(Console.ReadLine(), out opc)) break;
                }
                cajero1.aumentarMeses();
                // hasta aca significa que ingresó un num valido
                //switch (opc)
                //{
                //    case 1:

                //}


                // SEGUIR CON EL MENU DE OPCIONES
            }
            
        }
    }
}
