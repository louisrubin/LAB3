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
                int opc;
                Console.WriteLine($"\n{cajero1.getDiaActual.ToString("dd/MM/yyyy")} - MENU:");
                while (true)
                {
                    Console.Write("1- Crear cuenta bancaria\n2- Deposito\n3- Extraccion" +
                        "\n4- Ver ultimos movimientos\n5- Consultar saldo\n6- \n --> ");
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
                        // crear funcion en cajero qe verif si existe una cuenta
                        cajero1.getCuentaBancaria.verMovimientos();
                        break;
                    case 5:
                        // aca tambien
                        Console.WriteLine("SALDO: $", cajero1.getCuentaBancaria.getSaldoActual );
                        break;
                    case 6:
                        Console.WriteLine("\t:D");
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion correcta.");
                        break;
                }

                cajero1.aumentarDias();
                

                // opcion salir
                // CREAR METODO EN CUENTA BANC QUE VERIFIQUE LA DIFERENCIA
                // ENTRE LA ULTIMA FECHA DE EXTRACCION
                // QUE VERIFIQUE QUE DURANTE 60 DIAS TENGA SALDO > 20.000
                // al ejecutar el menu verifique siempre al inicio e
                // imprima mensaje con metodo aumento saldo negativo
            }
            
        }
    }
}
