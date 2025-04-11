Console.Write("Ingrese un numero: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Ingrese otro numero: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("El primer numero es mayor");
}
else if (num2 > num1)
{
    Console.WriteLine("El segundo numero es mayor");
}
else
{
    Console.WriteLine("Los numero son iguales");
}
