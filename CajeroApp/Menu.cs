using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    internal class MenuCajero
    {
        private static Cajero cajero1 = new Cajero("Av. Hernandarias 750");    // cajero ya creado
        public static void main()
        {

            while (true)
            {
                cajero1.ofrecerCredito();
                int opc;
                Console.WriteLine($"\n{cajero1.getDiaActual.ToString("dd/MM/yyyy")} - MENU:");
                while (true)
                {
                    Console.Write("1- Crear cuenta bancaria\n2- Deposito\n3- Extraccion" +
                        "\n4- Ver ultimos movimientos\n5- Consultar saldo\n6- SALIR\n --> ");
                    if (int.TryParse(Console.ReadLine(), out opc)) break;
                }

                switch(opc)
                {
                    case 1:
                        cajero1.crearCuenta();
                        break;
                    case 2:
                        cajero1.deposito();
                        break;
                    case 3:
                        cajero1.extraccion();
                        break;
                    case 4:
                        cajero1.verMovimientos();
                        break;
                    case 5:
                        Console.WriteLine($"SALDO: ${cajero1.getSaldoActual}");
                        break;
                    case 6:
                        Environment.Exit(0);    // cierra el programa
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion correcta.");
                        break;
                }
                cajero1.aumentarDias();

            }
            
        }
    }
}
