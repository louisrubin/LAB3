using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preguntas_y_Resp
{
    internal class Preg_y_Resp
    {
        private List<Pregunta> preguntasList = new List<Pregunta>();

        private int cantPrg;
        private double nota = 0;

        public void Main()
        {
            Console.Write("¿Cuantas preguntas desea agregar? (Max: 5): ");
            while (true)
            {
                this.cantPrg = int.Parse(Console.ReadLine());

                if (cantPrg > 5)   // verif cant de preg
                {
                    Console.Write("La cantidad supera a 5.\nIngrese: ");
                    continue;
                }
                if (cantPrg < 1)   // verif cant de preg
                {
                    Console.Write("Ingrese una cantidad correcta.\nIngrese: ");
                    continue;
                }

                break;
            }


            // CICLO PARA AGREGAR PREGUNTAS
            for (int i = 0; i < cantPrg; i++)
            {
                Console.Write($"\nIngrese pregunta {i + 1}: ");
                string preg = Console.ReadLine();
                preguntasList.Add(new Pregunta(preg));
            }

            // DIVIDE LA CANTID DE PREGUNTA Y ASIGNA CADA NOTA
            int califPorNota = 100 / preguntasList.Count;
            foreach (Pregunta p in preguntasList)
            {
                p.nota = califPorNota;
            }

            // CICLO PARA AGREGAR LAS RESPUESTAS A CADA PREGUNTA
            foreach (Pregunta preg in preguntasList)
            {
                Console.WriteLine("\n-------------------------------------------------------");
                Console.WriteLine($"\nAgregar Respuestas a la pregunta: \n{preg.pregMain}\n");
                preg.agregResp();
            }

            int notaFinal = 0;
            Console.WriteLine("\n\nCONTESTAR: ");
            foreach (Pregunta preg in preguntasList)
            {
                string[] resps = new string[preg.cantResp];

                Console.WriteLine(preg.pregMain);

                int x = 1;
                foreach (string str in preg.respuestasList)
                {
                    Console.WriteLine($"\t{x}- ", str);
                    x++;
                }

                Console.Write("Respuestas (separado por comas): ");
                string respContest = Console.ReadLine();

                resps = respContest.Split(",");     // DIVIDIMOS LOS ELEMENTs ENTRE COMAS

                for (int i = 0; i < resps.Length; i++)  // QUITAMOS LOS ESPACIOS
                {
                    resps[i] = resps[i].Trim();

                    if (preg.respCorrects.Contains(resps[i]))    // SI ESA RESP INGRESADA EXISTE EN EL ARRAY DE RESPS CORRECTAS
                    {
                        notaFinal += preg.nota / preg.cantResp;
                    }
                }
            }

            Console.WriteLine("\nNOTA FINAL: ", notaFinal);
        }

        public void MainPrueba()
        // TODO YA AGREGADO PARA PROBAR SIN ESTAR AGREGANDO PREG Y RESP
        {
            int notaFinal = 0;
            Pregunta pregunta1 = new Pregunta("¿pepe es gay?");
            preguntasList.Add(pregunta1);

            pregunta1.preguntasPrueba();    // autocompletado

            foreach (Pregunta preg in preguntasList)
            {
                notaFinal += preg.examenPrueba();
            }
        }

    }

    public class Pregunta
    {
        public string pregMain { get; set; }
        public int nota = 0, cantResp = 0;

        public List<string> respuestasList = new List<string>();

        // guardar cuales son las resp correctas (mas de uno)

        public string[] respCorrects { get; set; }

        public Pregunta(string pregMainParam)
        {
            pregMain = pregMainParam;       // uso del SETeador
        }

        public void agregResp()
        // metodo para agregar cada respuesta y las opciones correctas
        {
            int maxResp = 5;
            Console.Write($"¿Cuantas respuestas desea agregar? (Max: {maxResp}): ");
            while (true)
            {
                cantResp = int.Parse(Console.ReadLine());       // ingreso de dato de cantidad
                if (cantResp > maxResp)   // verif cant de preg
                {
                    Console.Write($"La cantidad supera a {maxResp}.\nIngrese: ");
                    continue;       // vuelve al inicio del While
                }
                if (cantResp < 2)   // verif cant de preg
                {
                    Console.Write("Ingrese una cantidad mayor a 1.\nIngrese: ");
                    continue;       // vuelve al inicio del While
                }

                respCorrects = new string[cantResp];        // inicializo el arreglo
                break;
            }

            for (int i = 0; i < cantResp; i++)
            {
                Console.Write($"Respuesta {i + 1}: ");
                respuestasList.Add(Console.ReadLine());
            }

            Console.Write("\n¿Cuáles son las Respuestas Correctas? \n(Ingrese separados por coma: 1,2,3): ");
            string nroResp = Console.ReadLine();

            respCorrects = nroResp.Split(",");      // retorna subelementos que separa la coma

            for (int i = 0; i < respCorrects.Length; i++)   // bucle para eliminar los espacios en las cadena
            {
                respCorrects[i] = respCorrects[i].Trim();
            }

            //Console.WriteLine(" cant resp : " + respCorrects.Length);

        }

        // METODO PARA AGREGAR TODOS LOS DATOS Y PROBAR APLICACION
        public void preguntasPrueba()
        {
            respuestasList.Add("si");
            respuestasList.Add("no");
            respuestasList.Add("no se");
            respuestasList.Add("tal vez");

            respCorrects = new string[3];

            respCorrects[0] = "1 ";
            respCorrects[1] = " 3 ";
            respCorrects[2] = " 4";

            for (int i = 0; i < respCorrects.Length; i++)   // bucle para eliminar los espacios en las cadena
            {
                respCorrects[i] = respCorrects[i].Trim();
                //Console.WriteLine(respCorrects[i]);
            }

        }

        public int examenPrueba()
        {
            int notaFinal = 0;
            Console.WriteLine("\n\nCONTESTAR: ");

            string[] resps = new string[cantResp];

            Console.WriteLine(pregMain);

            int x = 1;
            foreach (string resp in respuestasList)
            {
                Console.WriteLine($"\t{x}- ", resp.ToString());
                x++;
            }

            Console.Write("Respuestas (separado por comas): ");
            string respContest = Console.ReadLine();

            resps = respContest.Split(",");     // DIVIDIMOS LOS ELEMENTs ENTRE COMAS

            for (int i = 0; i < resps.Length; i++)  // QUITAMOS LOS ESPACIOS
            {
                resps[i] = resps[i].Trim();

                if (respCorrects.Contains(resps[i]))    // SI ESA RESP INGRESADA EXISTE EN EL ARRAY DE RESPS CORRECTAS
                {
                    notaFinal += nota / cantResp;
                }
            }

            return notaFinal;
        }
    }
}
