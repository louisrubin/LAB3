﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


Console.Write("ingrese mes: ");
int numIngr = int.Parse(Console.ReadLine());
Console.WriteLine("-------------");

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

DateTime queDiaSera() {
    //DateTime time = new DateTime(2024, numIngr, 01);
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

void diaYFindes(){
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

diaYFindes();

//Console.ReadLine();
