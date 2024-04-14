// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using LAB3;
/*
Console.Write("ingrese mes: ");
int numIngr = int.Parse(Console.ReadLine());
Console.WriteLine("-------------");
*/
// PROGRAMA PARA OBTENER EL FACTORIAL DE UN NUMERO INGRESADO POR CONSOLA


 int factorial(int num)
 {
     if (num == 1)
     {
         return num;
     }
     return num * factorial(num - 1);
 }


// PROGRAMA PARA OBTENER TABLA DE MULTIPLICAR DE UN NUMERO INGRESADO POR CONSOLA

int tablaMult(int num, int mult = 1)
{
    //int mult = num2;
    if (mult == 11)
    {
        return mult;
    }
    Console.WriteLine($"{num}x{mult} = {num*mult}");

    return tablaMult(num, mult+1);
}


/* 3.Realice un programa que solicite cuál fue el primer día del mes, por ejemplo el primer día del mes 
de marzo de 2022 fue un martes. Luego con esta información el sistema debe poder calcular que día será, 
el correspondiente a una fecha dada. Por lo cual el sistema podría preguntar, ingrese una fecha del 
mes de marzo y le diré que día cae. */

void ingresarDatos(out int num1)
{
    Console.Write("ingrese 1er num: ");
    num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("-------------");
}
void ingresarDatos2(out int num1, out int num2)
{
    Console.Write("ingrese 1er num: ");
    num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("-------------");
    Console.Write("ingrese 2do num: ");
    num2 = int.Parse(Console.ReadLine());
    Console.WriteLine("-------------");
}

DateTime queDiaSera() {
    //DateTime time = new DateTime(2024, numIngr, 01);

    int numIngr;
    ingresarDatos(out numIngr);     // la funcion me asigna el valor a "numIngr"

    Console.Write("ingrese dia: ");
    int dia = int.Parse(Console.ReadLine());

    DateTime fecha  = new DateTime(2024, numIngr, dia);

    Console.WriteLine( fecha.DayOfWeek );
    return fecha;
}
// queDiaSera();

/* 4.Realice un programa que solicite el primer día de cada uno de los doce 
meses del año. Con esta información podrá pedir al sistema que dada una 
determinada fecha el mismo le indique que día será. El sistema también 
podrá responder al requerimiento que fechas caen los fines de semana de 
un determinado mes.
 */

void diaYFindes()
{
    int numIngr;
    ingresarDatos(out numIngr);     // la funcion me asigna el valor a "numIngr"

    DateTime fechaReturn = queDiaSera();    // ejecuta el programa anterior
    
    DateTime fecha = new DateTime(fechaReturn.Year, fechaReturn.Month, 01);

    int cantDias = DateTime.DaysInMonth(fechaReturn.Year, numIngr);

    Console.WriteLine("\n------------------------------------\nFINES DE SEMANA:");

    for ( int x = 1; x <= cantDias; x++ ) 
    {
        if (fecha.DayOfWeek == DayOfWeek.Sunday || fecha.DayOfWeek == DayOfWeek.Saturday)
        {
            Console.Write(fecha.Day + ", ");        // si es sabado o domingo imprime
        }
        fecha = fecha.AddDays(1);       // aumenta en 1 dias la fecha
    }
    Console.WriteLine(" ");
}

// diaYFindes();

//Console.ReadLine();

/*
   5. Se agrega el nuevo requerimiento al sistema de fechas. 
    Se espera que pueda arrojar el monto de un presupuesto para 
    desarrollo considerando la siguiente información. La hora de 
    desarrollo será de $3000, el programador trabajará 4 horas por 
    día en el proyecto. Él estimo terminar con la incidencia 10 días 
    habiles, comenzando el 8 de abril de 2022.
*/

void montoPresupuesto(){
    double montoHora = 3000;
    double montoTotal = 0;
    int diasTrabajados = 0;
    DateTime fecha = new DateTime(2022, 04, 08);

    while ( diasTrabajados < 10)
    {
        fecha = fecha.AddDays(1);
        if (fecha.DayOfWeek != DayOfWeek.Saturday && fecha.DayOfWeek != DayOfWeek.Sunday)
        {
            montoTotal += montoHora * 4;
            diasTrabajados++;
        }
    }
    Console.WriteLine($"TOTAL PRESUPUESTO: ${montoTotal}");
    Console.WriteLine($"Dia final: {fecha.Day}\n{diasTrabajados}");
}

//montoPresupuesto();

// menuMatematica menuMatematica = new menuMatematica();
// menuMatematica.main();

PregYResp pregYResp = new PregYResp();


//pregYResp.MainPrueba();
//pregYResp.Main();

//DateTime fecha1 = new DateTime(2024, 4, 10);
//DateTime fecha2 = new DateTime(2024, 4, 15);
//DateTime fechaHoy = DateTime.Today;

//TimeSpan dif = fecha1;

//DateTime fechaHoy2 = new DateTime(fechaHoy.Year, fechaHoy.Month, fechaHoy.Day);
//Console.WriteLine(Math.Abs((fechaHoy - fecha1).Days));
//Console.WriteLine(fecha2.ToString("yyyy/MM/dd"));

//Menu menu = new Menu();

MenuCajero.main();
