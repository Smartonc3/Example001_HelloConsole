Console.Clear();

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

Console.WriteLine($"Задача 41. Cколько чисел больше 0 ввёл пользователь");
Console.Write($"Введи количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[m];

void InputNumbers(int m){
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Comparison(int[] massiveNumbers)
{
  int count = 0;
  for (int i = 0; i < massiveNumbers.Length; i++)
  {
    if(massiveNumbers[i] > 0 ) 
    count += 1; 
  }
  return count;
}

InputNumbers(m);

Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)} ");



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
Console.Write("Введите значения b1  ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите значения k1  ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите значения b2  ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("Введите значения k2 ");
double k2 = double.Parse(Console.ReadLine());

double IntersecX = (b1 - b2) / (k2 - k1);
double IntersecY = (b1 * k2 - b2 * k1) / (k2 - k1);

Console.WriteLine("Точка пересечения: (" + IntersecX + "; " + IntersecY + ")");
