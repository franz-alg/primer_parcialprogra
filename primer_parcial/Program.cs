int N;
int Factorial = 1;

Console.WriteLine("Ingrese un numero entero");
N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    Factorial = Factorial * i;

}
Console.WriteLine($"El Factorial de {N}  es {Factorial}");
Console.ReadLine();

Console.WriteLine("Los numeros divisibles entre 3 son ");

for (int i = 1; i <= N; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine(i);

    }


}
Console.ReadLine();

Console.WriteLine("Los numeros divisibles entre 5 son ");

for (int i = 1; i <= N; i++)
{
    if (i % 5 == 0)
    {
        Console.WriteLine(i);

    }
}
Console.ReadLine();

int n1 = 1;
Console.Write("La sencuencia de N es:");

while (N >= n1)
{


    Console.Write(n1 + " ");
    n1 = n1 + 2;

}
Console.ReadLine();

Console.WriteLine($"Factorial = {Factorial}");
Console.ReadLine();



