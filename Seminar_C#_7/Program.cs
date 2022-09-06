Console.Clear();


// //  Задать Двухмерный массив MxN, Заполнить случайними числями. 

// Console.Write("Введите высоту матрицы");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите высоту матрицы");
// int n = int.Parse(Console.ReadLine());

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

// // // void Print(int[,] mart)                            //   Метод печать. Но я изпользовал в 1 методе сразу. 
// // // {
// // //    for (int i = 0; i < mart.GetLength(0); i++)
// // //     {
// // //         for (int j = 0; j <mart.GetLength(1); j++)
// // //         {
// // //             Console.Write(mart[i,j] + " ");
// // //         }
// // //         Console.WriteLine();
// // //     }
// // // }

// FillAray(array);
// // // Print(array);


//  //  //  -----------------------------------------------------------------------------------------------------------------

// // // Задание 48:   2 мерный массив M и N, где каждый элимент массива находится пл формуле Amn = M+N. 

// // //  M =3, N = 4
// // //  0 1 2 3 
// // //  1 2 3 4 
// // //  2 3 4 5                     Сколадываем кардинаты.  


// Console.WriteLine("Введите высоту матрицы");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите высоту матрицы");
// int n = int.Parse(Console.ReadLine());

// int x = 0;
// int y = 0;

// int[,] array = new int[m, n];

// void FillAray(int[,] mart){
//     for (int i = 0; i < mart.GetLength(0); i++)
//     {
//         for (int j = 0; j <mart.GetLength(1); j++, x++)
//         {
//             mart[i, j] = i + j;
//             Console.Write(mart[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }


// FillAray(array);




// //  // //  ---------------------------------------------------------------------------------------------------------


// // Задание 49:   2 мерный массив M и N, Найти элименты у которого оба элимента чётные, и заменить их на квадраты. 

// //  6 4 7 2           36 4 49 2 
// //  5 9 2 3           5  9  4 3  
// //  8 4 2 4           64 4  4 4          


// Console.WriteLine("Введите высоту матрицы");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите высоту матрицы");
// int n = int.Parse(Console.ReadLine());


// int[,] array = new int[m, n];

// void FillAray(int[,] mart){
//     for (int i = 0; i < mart.GetLength(0); i++)
//     {
//         for (int j = 0; j < mart.GetLength(1); j++)
//         {
//             mart[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void CheckArray(int[,] mart)
// {
//     for (int i = 0; i < mart.GetLength(0); i += 2)
//     {
//         for (int j = 0; j <mart.GetLength(1); j += 2)
//         {
//             mart[i, j] = mart[i, j] * mart[i, j];
//         }  
//     }
// }

// void Print(int[,] mart)                          
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
// Console.WriteLine("");
// CheckArray(array);
// Print(array);



//  // //  ---------------------------------------------------------------------------------------------------------


// //  // //  ---------------------------------------------------------------------------------------------------------


// // Задание 51:   2 мерный массив M и N, Суммву элиментов на главной диогоналию . 

// //  (6)  4   7   2           
// //   5  (9)  2   3    -> 6 + 9 + 2 = 17
// //   8   4  (2)  4                    


Console.WriteLine("Введите высоту матрицы");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите высоту матрицы");
int n = int.Parse(Console.ReadLine());


int[,] array = new int[m, n];

void FillAray(int[,] mart){
    for (int i = 0; i < mart.GetLength(0); i++)
    {
        for (int j = 0; j < mart.GetLength(1); j++)
        {
            mart[i, j] = new Random().Next(1, 10);
        }
    }
}

void CheckArray(int[,] mart)
{
    int sum = 0;
    for (int i = 0; i < mart.GetLength(0); i++)
    { 
        for (int j = 0; j <mart.GetLength(1); j++)
        {
           if (i == j) sum = sum + mart[i, j];
        }  
    }
    Console.Write(sum + " Сумма ");
}

void Print(int[,] mart)                          
{
   for (int i = 0; i < mart.GetLength(0); i++)
    {
        for (int j = 0; j <mart.GetLength(1); j++)
        {
            Console.Write(mart[i,j] + " ");
        }
        Console.WriteLine();
    }
}

FillAray(array);
Print(array);
Console.WriteLine("");
CheckArray(array);

