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


Console.Write("Введите Ширину и Длину массива 1 числом - ");
int m = int.Parse(Console.ReadLine());
int n = m;

int[,] array = new int[m, n];

void FillAray(int[,] mart){
    for (int i = 0; i < mart.GetLength(0); i++)
    {
        for (int j = 0; j <mart.GetLength(1); j++)
        {
            mart[i, j] = new Random().Next(1, 10);
            Console.Write(mart[i,j] + " ");
        }
        Console.WriteLine();
    }
}

FillAray(array);

void SumEliment(int[,] mart){
    int sum = 0;
    int sumMin = 0;
    for (int i = 0; i < mart.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j <mart.GetLength(1); j++)
        {
            sum = sum + mart[i, j];
        }
        Console.WriteLine(sum);
        if (i == 0)
        {
            sumMin = sum;
        }
        else
        {
            if (sumMin < sum)
            {
                sumMin = sumMin;
            }
            else
            {
                sumMin = sum;
            }
        }
        Console.WriteLine("Самая маленькая сумма - находится в страке " + i + " и состовлает " + sumMin);
    } 
     
}

SumEliment(array);



















// void Print(int[,] mart)                            //   Метод печать. Но я изпользовал в 1 методе сразу. 
// {
//    for (int i = 0; i < mart.GetLength(0); i++)
//     {
//         for (int j = 0; j <mart.GetLength(1); j++)
//         {
//             Console.Write(mart[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// FillAray(array);
// Print(array);
