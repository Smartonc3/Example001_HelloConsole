Console.Clear();

// // // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// // // m = 3, n = 4.
// // // 0,5 7 -2 -0,2
// // // 1 -3,3 8 -9,9
// // // 8 7,8 -7,1 9

Console.WriteLine("Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
Console.WriteLine();

Console.Write("Введите высоту матрицы  ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите высоту матрицы  ");
int n = int.Parse(Console.ReadLine());

double[,] array = new double[m, n];

void FillAray(double[,] mart){
    // Random random = new Random();
    for (int i = 0; i < mart.GetLength(0); i++)
    {
        for (int j = 0; j <mart.GetLength(1); j++)
        {
            mart[i, j] =  new Random().NextDouble() * 20 - 10; 
            Console.Write("{0,6:F2}", array[i, j]);
        }
        Console.WriteLine();
    }
}

FillAray(array);

// // // ---------------------------------------------------------------------------------------------------------

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
Console.WriteLine();



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.WriteLine("Массив подобрянный Случайным Оброзощм ");

int q = new Random().Next(1, 10);
int w = new Random().Next(1, 10);

int[,] array1 = new int[q, w];

void FillAray1(int[,] mart){
    for (int i = 0; i < mart.GetLength(0); i++)
    {
        for (int j = 0; j < mart.GetLength(1); j++)
        {
            mart[i, j] = new Random().Next(1, 10);
            Console.Write(mart[i,j] + " ");
        }
        Console.WriteLine();
    }
}

FillAray1(array1);

Console.Write("Введите значения по кардинату X ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите значения по кардинату Y ");
int y = int.Parse(Console.ReadLine());

if (x > array1.GetLength(0) || y > array1.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {x} строки и столбца {y}  равно {array[x-1, y-1]}");
}



// // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
Console.WriteLine();


int t = new Random().Next(1, 10);
int g = new Random().Next(1, 10);

int[,] array2 = new int[t, g];

void FillAray2(int[,] mart){
    for (int i = 0; i < mart.GetLength(0); i++)
    {
        for (int j = 0; j < mart.GetLength(1); j++)
        {
            mart[i, j] = new Random().Next(1, 10);
            Console.Write(mart[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void CheckArray2(int[,] mart)
{
    double sum = 0;
    for (int j = 0; j <mart.GetLength(1); j++)
    { 
        for (int i = 0; i < mart.GetLength(0); i++)
        {
           sum = (sum + mart[i, j]);
        }  
        Console.WriteLine($"Сумма от {j + 1} столбика = {sum}  " );
        sum = 0;
    }
    
}


FillAray2(array2);
Console.WriteLine("");
CheckArray2(array2);




