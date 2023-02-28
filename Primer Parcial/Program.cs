// aquí comienza todo -Inserta musica epica!!!

int factorial, num, nx3, numw1, nx5, numw2, secuencia;
string name;

try
{
    Console.WriteLine("Hola, bienvenid@ dime, ¿Cual es tu nombre?");
        name = Console.ReadLine();
//Inicia el código solicitando al usuario el numero que desea factorizar, el cual será impreso al final del programa.
    Console.WriteLine($"Hola {name}, bienvenid@, por favor inserte a continuación el numero que desea factorizar:");
        num = Convert.ToInt32(Console.ReadLine());
        factorial = 1;
 
//2da parte del código donde realice la división entre 3, siendo los numeros enteros positivos menores o iguales que N.
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

//3ra parte del código donde realice la división entre 5, siendo los numeros enteros positivos menores o iguales que N.
    Console.WriteLine();
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
    Console.WriteLine();

    //Acá realizo la 4ta parte del código, realizando la secuencia de N numeros terminando en un valor mayor que N.
    Console.WriteLine("\nAhora por favor inserta el numero que deseas para la secuencia de numeros: ");
        secuencia = Convert.ToInt32(Console.ReadLine());
    Console.Write($"\nEl resultado de {secuencia} es:");
    int s = 1;
    Console.Write(" " + s);
    do
    {
        s += 2;
        Console.Write(" " + s);
    }
    while (s <= secuencia);

//Acá determino el factorial del numero.
    if (num == 0)
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
        Console.Write("X" + (num - n));
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
} catch
{ 
    Console.WriteLine("Lo siento has insertado un dato no valido, por favor intentalo de nuevo!"); 
}
Console.ReadKey();