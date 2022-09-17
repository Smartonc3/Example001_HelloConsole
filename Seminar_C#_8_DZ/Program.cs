Console.Clear();


// // // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// // // Например, задан массив:
// // // 1 4 7 2
// // // 5 9 2 3
// // // 8 4 2 4
// // // В итоге получается вот такой массив:
// // // 7 4 2 1
// // // 9 5 3 2
// // // 8 4 4 2


// int m = Convert.ToInt32(new Random().Next(3, 5));
// int n = m + Convert.ToInt32(new Random().Next(3, 5));

// int[,] array = new int[m, n];

// void FillAray(int[,] arr){
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(1, 10);
//             if(arr[i, j] < 0) Console.Write(arr[i, j] + " ");
//             else Console.Write(" " + arr[i, j] + " "); 
//             // Console.Write(mart[i,j] + " ");
//         }
//         Console.WriteLine();
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// void Print(int[,] mart)                          
// {
//    for (int i = 0; i < mart.GetLength(0); i++)
//     {
//         for (int j = 0; j <mart.GetLength(1); j++)
//         {
//             if(mart[i, j] < 0) Console.Write(mart[i, j] + " ");
//             else Console.Write(" " + mart[i,j] + " ");
//         }
//         Console.WriteLine();
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// void Transverse(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       {
//         if (array[i, k] < array[i, k + 1])
//         {
//           int temp = array[i, k + 1];
//           array[i, k + 1] = array[i, k];
//           array[i, k] = temp;
//         }
//       }
//     }
//   }
// }



// FillAray(array);
// Transverse(array);
// Console.WriteLine();
// Print(array);





// // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7
// // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// Console.Write("Введите Ширину и Длину массива 1 числом - ");
// int m = int.Parse(Console.ReadLine());
// int n = m;

// int[,] array = new int[m, n];

// void FillAray(int[,] mart){
//     for (int i = 0; i < mart.GetLength(0); i++)
//     {
//         for (int j = 0; j <mart.GetLength(1); j++)
//         {
//             mart[i, j] = new Random().Next(1, 10);
//             Console.Write(mart[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// FillAray(array);

// void SumEliment(int[,] mart){
//     int sum = 0;
//     int sumMin = 0;
//     int index = 0;
//     int iFor1 = 1;
//     for (int i = 0; i < mart.GetLength(0); i++)
//     {
//         sum = 0;
//         for (int j = 0; j <mart.GetLength(1); j++)
//         {
//             sum = sum + mart[i, j];
//         }
//         if (i == 0)
//         {
//             sumMin = sum;
//         }
//         else
//         {
//             if (sumMin <= sum)
//             {
//                 sumMin = sumMin;
//             }
//             else
//             {
//                 sumMin = sum;
//                 index = i;
//             }
//         }
        
//     } 
//      Console.WriteLine("Самая маленькая сумма - находится в страке " + index + " и состовлает " + sumMin);
// }

// SumEliment(array);




// // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// // Например, даны 2 матрицы:
// // А В
// // 1 4 | 3 5
// // 3 5 | 1 2

// // Результирующая матрица будет:
// // С
// // 7 13
// // 14 25

// // Произведением двух матриц А и В называется матрица С, элемент которой, находящийся на пересечении i-й строки и j-го столбца, равен сумме произведений элементов i-й строки матрицы А на соответствующие (по порядку) элементы j-го столбца матрицы В.

// // С (0,0) = А(0,0) * B(0,0) + A(0,1) * B(1,0) = 1 · 3 + 4 · 1 = 3 + 4 = 7
// // С (0,1) = А(0,0) * B(0,1) + A(0,1) * B(1,1) = 1 · 5 + 4 · 2 = 5 + 8 = 13
// // С (1,0) = А(1,0) * B(0,0) + A(1,1) * B(1,0) = 3 · 3 + 5 · 1 = 9 + 5 = 14
// // С (1,1) = А(1,0) * B(0,1) + A(1,1) * B(1,1) = 3 · 5 + 5 · 2 = 15 + 10 = 25

// // Произведение двух матриц АВ имеет смысл только в том случае, когда число столбцов матрицы А совпадает с числом строк матрицы В.

// // В произведении матриц АВ число строк равно числу строк матрицы А , а число столбцов равно числу столбцов матрицы В.



// Console.Write("Введите Ширину и Длину массива 1 числом - ");
// int m = int.Parse(Console.ReadLine());
// int n = m;

// int[,] array = new int[m, n];
// int[,] array1 = new int[m, n];

// void FillAray(int[,] mart){
//     for (int i = 0; i < mart.GetLength(0); i++)
//     {
//         for (int j = 0; j <mart.GetLength(1); j++)
//         {
//             mart[i, j] = new Random().Next(1, 10);
//             Console.Write(mart[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Массит A ");
// FillAray(array);
// Console.WriteLine();
// Console.WriteLine("Массит B ");
// FillAray(array1);

// int[,] array2 = new int[m, n];

// void FillAray2(int[,] mart){
//     for (int i = 0; i < mart.GetLength(0); i++)
//     {
//         for (int j = 0; j <mart.GetLength(1); j++)
//         {
//             for (int k = 0; k < mart.GetLength(1); k++)
//             {
//                 mart[i,j] += array[i, k] * array1[k, j];
//             }
            
//             Console.Write(mart[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// FillAray2(array2);


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



// int m = Convert.ToInt32(new Random().Next(3, 5));
// int n = Convert.ToInt32(new Random().Next(3, 5));
// int y = Convert.ToInt32(new Random().Next(3, 5));

// int[,,] array = new int[m, n, y];

// void FillAray(int[,,] arr){
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 arr[i, j, k] = new Random().Next(10, 99);
//                 Console.Write($"{arr[i,j,k]} ({i}{j}{k}) ");
//             } 
//         }
//         Console.WriteLine();
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// FillAray(array);
// Console.WriteLine();



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int n = Convert.ToInt32(new Random().Next(3, 7));
int[,] Matrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= Matrix.GetLength(0) * Matrix.GetLength(1))
{
  Matrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < Matrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= Matrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > Matrix.GetLength(1) - 1)
    j--;
  else
    i--;
}



void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($"0{array[i,j]} ") ;

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}


PrintArray(Matrix);