// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт максимальное.
Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт максимальное.");
Console.WriteLine("Введите Первое  число для, ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Второе  число для, ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Максимальное число = " + a );
}
else
{
    Console.WriteLine("Максимальное число = " + b);
}

Console.WriteLine("");
Console.WriteLine("");

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
Console.WriteLine("");

Console.WriteLine("Введите Первое  число, ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Второе  число, ");
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Трете  число, ");
int f = Convert.ToInt32(Console.ReadLine());

int max = c;

if (max > d)
{
    if (max > f)
    {
        Console.WriteLine("Максимальное число = " + max);
    }

    else
    {
        max = f;
        Console.WriteLine("Максимальное число = " + max);
    }
}

else
{
    max = d;
    if (max > f)
    {
        Console.WriteLine("Максимальное число = " + max);
    }

    else
    {
        max = f;
        Console.WriteLine("Максимальное число = " + max);
    }
}
Console.WriteLine("");
Console.WriteLine("");


// Задача 6 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Задача 6 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
Console.WriteLine("");

Console.WriteLine("Введите число, ");
int q = Convert.ToInt32(Console.ReadLine());

if ( q % 2 == 0 )
{
    Console.WriteLine("Число чётное " );
}

else
{
    Console.WriteLine("Число не чётное " );
}

Console.WriteLine("");
Console.WriteLine("");


//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
Console.WriteLine("");

Console.WriteLine("Введите число, ");
int w = Convert.ToInt32(Console.ReadLine());

int index = 1;
int size = w;
int z = 2;

while (index < size)
{
    if (z % 2 == 0)
    {
        Console.Write(z);
        Console.Write("," );
        index = index + 1;
        z = z + 1;
    }
    
    else
    {
        z = z + 1;
        index = index + 1;
    }
}

Console.WriteLine("");
Console.WriteLine("");


// Два друга и собака. 
Console.WriteLine("Два друга и собака. маё решения");
Console.WriteLine();

int distance = 100;   // Дистанция между друзями.
int SpeedFirst = 1;   //  Скорость 1 друга.
int SpeedSecond = 2;  //  Скорость 2 друга.
int SpeedDogs = 3;    //  Скорость Сабаки.
int NumberRun = 0;    //  Сколько раз Пробежала сабака.
int Directions = 1;   //  К каму бежит собака. 
int TravelTime = 0;  // Время в пути собаки.
int GeneralApproaches = 0;  // Обшая скорость сабаки и друга.


while (distance > 3)
{
    if (Directions == 1)
    {
        GeneralApproaches = SpeedSecond + SpeedDogs;
        TravelTime = distance / GeneralApproaches;
        NumberRun = NumberRun + 1;
        Directions = 2;
        distance = distance - (SpeedFirst + SpeedSecond) * TravelTime;
    }
    else
    {
        GeneralApproaches = SpeedFirst + SpeedDogs;
        TravelTime = distance / GeneralApproaches;
        NumberRun = NumberRun + 1;
        Directions = 1;
        distance = distance - (SpeedFirst + SpeedSecond) * TravelTime;
    }
}

Console.WriteLine( "Собака пробежала - " + NumberRun + " раза" );
Console.WriteLine();
Console.WriteLine();


// Два друга и собака.  Решение Преподователя. 

Console.WriteLine("Два друга и собака. Решения Преподователя");
Console.WriteLine();

int count = 0;
int distance1 = 100;
int FirstFriensdSpeed = 1;
int SecondFriendSpeed = 2;
int dogSpeed = 3;
int friend =2; 
int time = 0;

while (distance1 > 3)
{
    if (friend == 1)
    {
        Console.WriteLine($"Собака бежиь навстречу 1 другу");
        time = distance1 / (FirstFriensdSpeed + dogSpeed);
        Console.WriteLine($"Время в пути {time}");
        friend = 2;
    }
    else
    {
        Console.WriteLine($"Собака бежиь навстречу 2 другу");
        time = distance1 / (SecondFriendSpeed + dogSpeed);
        Console.WriteLine($"Время в пути {time}");
        friend = 1;
    }
    distance1 = distance1 - (FirstFriensdSpeed + SecondFriendSpeed) * time;
    Console.WriteLine($"Осталось растояния");
    count++;
    Console.WriteLine($"Сбегала {count} раз");
}
Console.WriteLine($"Собака успела пробежать {count} раз.");

Console.WriteLine();
Console.WriteLine();
