Console.Clear();

// 24 задание
// Написать программу которая принимает на вход число А и выдаёт сумму чисел от 1 до А:

Console.WriteLine("Введите число Q. : ");
int Q = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= Q; i++)
{
    sum = sum + i;
}
// Console.WriteLine($"{sum}");     Почему то пишут так
Console.WriteLine(sum);


// 26 задание
// Написать число и выдать количество цифр в этом числе. Маё решение. 

Console.WriteLine("Введите число A. : ");
int A = Convert.ToInt32(Console.ReadLine());
int b = Math.Abs(A); 
string str = Convert.ToString(b); 
int length = str.Length;
Console.WriteLine(length);


// 26 задание
// Написать число и выдать количество цифр в этом числе. Решение одногрупника.
//Решение  одногрупника.

Console.WriteLine("Введите число A. : ");
int A = Convert.ToInt32(Console.ReadLine());
int length = 0;
if (A / 10 == 0)
{
    Console.WriteLine("1 : ");
}
else
{
    while (Math.Abs(A) > 0)
    {
        A = A / 10;
        length ++;
    }
Console.WriteLine(length);
}

// 26 задание
// Написать число и выдать количество цифр в этом числе. 
// Решение Второго одногрупника.

Console.WriteLine("Введите число A. : ");
int A = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int length = 0;
if (A > 0)
{
    while (A != 0)
{
    A = A / 10;
    length ++;
}
Console.WriteLine(length);
}
else
{
    Console.WriteLine(1);
}


// Задача 28: 
// Программа которя принимает число N и Выдаёт произведения от 1 до N
//  4 -> 24
//  5 -> 120 


Console.WriteLine("Введите число Q. : ");
int Q = Convert.ToInt32(Console.ReadLine());
int sum = 1;

for (int i = 1; i <= Q; i++)
{
    // sum = sum * i;
    sum *= i;
}
Console.WriteLine($"{sum}");
Console.WriteLine(sum);


// Задача 30
// Программа которая состоит из массива с 8 этиментами м заполнает их 0 и 1 в случайном поядке.


int[] arrey = new int[8];
int i = 0;
while (i < arrey.Length)
{
    arrey[i] = new Random().Next(0,2);
    Console.Write(arrey[i] + " ");
    i++;
    
}   


// тотже самое через for

int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,2);
    Console.Write(array[i]);
}


