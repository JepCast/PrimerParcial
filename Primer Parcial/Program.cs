// aquí comienza todo -Inserta musica epica!!!
int factorial, num;
Console.WriteLine("Por favor inserte a continuación el numero que desea factorizar");
num= Convert.ToInt32(Console.ReadLine());
factorial = 1;
for (int i = 1; i <= num; i++)
{
    factorial *= i;
}
Console.WriteLine($"El factorial del {num} es: {factorial}");
