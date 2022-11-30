//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите число c: ");
int c = int.Parse(Console.ReadLine()!);
if (a>b)
{
    if (a>c)
    {
        Console.Write("max= "+a);
    }
    else
    {
        Console.Write("max= "+c);
    }
}
else if (b>a)
{
    if (b>c)
    {
        Console.Write("max= "+b);
    }
    else
    {
        Console.Write("max= "+c);
    }
}
else if (c>a)
{
    if (c>b)
    {
        Console.Write("max= "+c);
    }
    else
    {
        Console.Write("max= "+b);
    }
}
else
{
    Console.Write("Числа равны, попробуйте еще раз");
}