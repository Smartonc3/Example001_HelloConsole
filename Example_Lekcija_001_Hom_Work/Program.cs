// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт максимальное.

Console.WriteLine("Введите Первое целое число, ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Второе целое число, ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Максимальное число = " + a );
}
else
{
    Console.WriteLine("Максимальное число = " + b);
}
