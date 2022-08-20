// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
Console.WriteLine();
Console.Write("Введи трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
string stringa = Convert.ToString(a);
Console.WriteLine("вторая цифра = "+stringa[1]);
Console.WriteLine();
Console.WriteLine();

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Решение преподователя. 

Console.WriteLine("Решение преподователя.");
int Number = 0;
Console.WriteLine("Введите трёхзначное число: ");
Number = Convert.ToInt32(Console.ReadLine());
if (Number >= 100 && Number <= 999)
{
    int DecreaseByTen = Number / 10;
    int LastDigit = DecreaseByTen % 10;
    Console.WriteLine("Вторая цифра =" + LastDigit);
}
else
{
    Console.WriteLine("Это не трёхзначное число!");
}


// -------------------------------------------------------------------------------------------------


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


//  Решение преподователя.

Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());
a = Math.Abs(a);
if (a >= 100)
{
    if (a > 999)
        {
            int i = 10;
            while (a / i > 1000)
                {
                    {i = i * 10;}
                Console.WriteLine("Третя цифра - " + (a / i) % 10);
                }
        else
            {
                Console.WriteLine("Третя цифра - " + a % 10);
            }
        }
}    
else
{
    Console.WriteLine("Третьего чифры нет");
}


// -------------------------------------------------------------------------------------------------


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


// Задача 15: Решение Преподователя. 
Console.WriteLine("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
Console.WriteLine();
Console.Write("Введи день недели: ");
int d = Convert.ToInt32(Console.ReadLine());

if (d == 6 | d == 7)
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Введите правильный день недели.");
}


// -------------------------------------------------------------------------------------------------



// Доп. задача: Игра угадайка. Программа загадывает случайное число. Пользователь его угадывает. Если пользователь дает неправильный ответ, 
//                                то программа сообщает, больше загаданное число или меньше
// Доп. задача с усложнением: на отгадывание дается 3 попытки.


int d = new Random().Next(1, 10);
Console.WriteLine("Загадонная цифра = " + d);
Console.Write("Введите Загаданное число , ");
int f = Convert.ToInt32(Console.ReadLine());
int index3 = 0;


while (index3 < 3)
{  
    if (d == f)
        {
            Console.WriteLine("Вы угодали число");
            break;
        }
        else
        {
            while (index3 < 3)
            {
                if (d == f)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Число не угадано. Попробуйте сново: ");
                    int g = Convert.ToInt32(Console.ReadLine());
                    f = g;
                    index3++;
                }
            }
            
        }
Console.Write("Попыток больше нет , ");
}





Console.WriteLine("Задача 'Дополнительная' ");

int randomNumber = new Random().Next(100, 110);


void AttemptCounter(int maxCounter){

  int counter = 1;
  while (counter <= maxCounter) {

    Console.Write("Попытка номер " + counter);
    Console.Write(".   Введи число: ");
    int myNumber = Convert.ToInt32(Console.ReadLine());

    if (myNumber == randomNumber){
      Console.WriteLine("Поздравляю, ты угадал! ");
      break;
    }
    else {
      CheckingTheNumber(myNumber, randomNumber);
      counter++;
    }
  }
}

void CheckingTheNumber(int myNumber, int randomNumber) {

  if (myNumber > randomNumber) {
    Console.WriteLine("Не угадал, твоё число великовато");
  }
  else Console.WriteLine("Не угадал, твоё число маловато");
}

Console.WriteLine("Игра до 3 попыток");
AttemptCounter(3);

Console.WriteLine("В основные попытки не уложился. Продолжим ? (напиши да/нет)");

string? yesNo = Console.ReadLine();

if (yesNo == "да"){
AttemptCounter(1000);
}
else Console.Write("Загаданное число было: " + randomNumber);







int g = new Random().Next(1, 10);
Console.WriteLine("Загадонная цифра = " + d);
Console.Write("Введите Загаданное число , ");
int h = Convert.ToInt32(Console.ReadLine());

if (g == h)
    {
        Console.WriteLine("Вы угодали число");
      
    }
    else
    {
        Console.WriteLine("Число не угадано. Попробуйте сново: ");
    }


