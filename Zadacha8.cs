//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
int i = 2;
if (N > 0)
    while (i <= N)
    {
        Console.Write(i + " ");
        i = i + 2;
    }
else if (N < 0 && N % 2 == 0)
    while (N <= -i)
    {
        Console.Write(N + " ");
        N = N + 2;
    }
else if (N < 0 && N % 2 == -1)
{
    N = N + 1;
    while (N <= -i)
    {
        Console.Write(N + " ");
        N = N + 2;
    }
}
else
    Console.Write("Попробуйте еще раз");
