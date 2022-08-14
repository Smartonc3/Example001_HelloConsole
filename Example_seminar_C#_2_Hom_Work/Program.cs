// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
Console.WriteLine();
Console.Write("Введи трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
string stringa = Convert.ToString(a);
Console.WriteLine("вторая цифра = "+stringa[1]);
Console.WriteLine();
Console.WriteLine();


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.WriteLine();
Console.Write("Введи число: ");
int b = Convert.ToInt32(Console.ReadLine());
string stringb = Convert.ToString(b);
int size = 3;
int length = stringb.Length;

if (length < size)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine("третья цифра = "+stringb[2]);
}

Console.WriteLine();
Console.WriteLine();


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
Console.WriteLine();
Console.Write("Введи день недели: ");
int d = Convert.ToInt32(Console.ReadLine());

if (d < 8)
{
    if (d == 6)
    {
        Console.WriteLine("Суббота");
    }
    else
    {
        if (d == 7)
        {
            Console.WriteLine("Воскресения");
        }
        else
        {
            Console.WriteLine("Рабочий день.");
        }
    }
}
else
{
    Console.WriteLine("Введите правильный день недели.");
}
