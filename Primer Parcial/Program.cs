// aquí comienza todo -Inserta musica epica!!!
int factorial, num;

Console.WriteLine("Hola, bienvenido, favor inserte a continuación el numero que desea factorizar");
    num= Convert.ToInt32(Console.ReadLine());
    factorial = 1;

if (num == 0 )
    for (int i = 1; i <= num; i++)
    {
        factorial *= i;
    }

Console.Write("\nEl factorial de ");
for (int i = 1; i <= num; i++)
    {
        factorial *= i;
    }
Console.Write(num);
int n = 1;
    
while (n < num)
    {
        Console.Write("X" + (num-n));
        n++;
    } 

if (num == 0) 
    { 
    Console.Write(" es = 0"); 
}else 
{
    Console.Write(" es = " + factorial);
}

