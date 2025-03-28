do
{
    Console.Write("Ingrese un numero entero: ");
    var numero = (Console.ReadLine());

    if (int.TryParse(numero, out int numberInt))
    {
        if (numberInt % 2 == 0)
        {
            Console.WriteLine($"El numero {numero} es par");
        }
        else
        {
            Console.WriteLine($"El numero {numero} es impar");
        }
        return numberInt;
    }
    else
    {
        Console.WriteLine("Hay que leer el enunciado, ingresa un numero");
    }
} while (true);

