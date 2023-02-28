// aquí comienza todo -Inserta musica epica!!!
int factorial, num, nx3, numw1, nx5, numw2;

Console.WriteLine("Hola, bienvenido, por favor inserte a continuación el numero que desea factorizar:");
    num= Convert.ToInt32(Console.ReadLine());
    factorial = 1;

Console.WriteLine("\nAhora por favor inserta un numero entero positivo que desees dividir entre 3: ");
nx3 = Convert.ToInt32(Console.ReadLine());
numw1 = 1;
Console.Write("Los numeros enteros positivos menores o iguales divisibles entre 3 son: ");
while (numw1 <= nx3)
{
    if (numw1 % 3 == 0)
    {
        
        Console.Write(numw1 + " ");
    }
    numw1++;
}

Console.WriteLine("\nAhora por favor inserta un numero entero positivo que desees dividir entre 5: ");
nx5 = Convert.ToInt32(Console.ReadLine());
numw2 = 1;
Console.Write("Los numeros enteros positivos menores o iguales divisibles entre 5 son: ");
while (numw2 <= nx5)
{
    if (numw2 % 5 == 0)
    {

        Console.Write(numw2 + " ");
    }
    numw2++;
}






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
    }
else 
    {
        Console.Write(" es = " + factorial);
    }

