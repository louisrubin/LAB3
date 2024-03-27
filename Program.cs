// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


Console.WriteLine("ingrese numero: ");
int numIngr = int.Parse(Console.ReadLine());
Console.WriteLine("----------------");

// PROGRAMA PARA OBTENER EL FACTORIAL DE UN NUMERO INGRESADO POR CONSOLA

/*
 int factorial(int num)
 {
     if (num == 1)
     {
         return num;
     }
     return num * factorial(num - 1);
 }
*/

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

//Console.WriteLine(factorial(numIngr));
tablaMult(numIngr);
Console.ReadLine();