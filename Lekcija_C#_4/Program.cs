Console.Clear();

// // Двухиерные массивы. 

// //  string[,] table = new string[2,3];   -  Строчный тип

// //  int[,] matrix = new int[5,8];    -   Маьрица Чисел  5 сторока, 8 столбикт.


// // string[,] table = new string[2, 5];   //  Определили таблицу строк из 2 срочек и 5 сталбцов.

// //                          String.Empty
// //                          table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]
// //                          table[1,0] table[1,1] table[1,2] table[1,3] table[1,4]

// // table[1, 2] = "Словл";                // Обрашаемся к таблице. на 1 строку и 2 столбик и задаём значения.

// // for (int rows = 0; rows < 2; rows++)
// // {
// //     for (int columns = 0; columns < 5; columns++)
// //     {
// //         Console.WriteLine($"-{table[rows, columns]}-");
// //     }
// // }



// // int[,] matrix = new int[3, 4];

// // for (int i = 0; i < 3; i++)
// // {
// //     for (int j = 0; j < 4; j++)
// //     {
// //         Console.Write($"{matrix[i, j]} ");
// //     }
// //     Console.WriteLine();
// // }

// //  Console.WriteLine();
// // Console.WriteLine("matrix.GetLength");
// //  Console.WriteLine();
// // // Тоже самое но чтобы определить автоматом сколько строк и столбиков запрограмирована. 
// // // Делается с помошю matrix.GetLength(0); - ) Означает количестро строк. В нашем случаи 3. 
// // //                   matrix.GetLength(1); - ) Означает количестро столбиков. В нашем случаи 4. 


// // int[,] matrix1 = new int[3, 4];

// // for (int q = 0; q < matrix1.GetLength(0); q++)
// // {
// //     for (int w = 0; w < matrix1.GetLength(1); w++)
// //     {
// //         Console.Write($"{matrix1[q, w]} ");
// //     }
// //     Console.WriteLine();
// // }


// // Метод печати двухмерноц матрицы и заполнения числами.


// // void PrintAray(int[,] matr)            //  Печатаем массив. 
// // {
// //     for (int r = 0; r < matr.GetLength(0); r++)
// //     {
// //         for (int t = 0; t < matr.GetLength(1); t++)
// //         {
// //             Console.Write($"{matr[r, t]} ");
// //         }
// //         Console.WriteLine();
// //     }
// // }

// // void FillAray(int[,] matr)   // Заполнаем Случайними числами
// // {
// //     for (int r = 0; r < matr.GetLength(0); r++)
// //     {
// //         for (int t = 0; t < matr.GetLength(1); t++)
// //         {
// //             matr[r, t] = new Random().Next(1,10);   
// //         }
// //     }
// // }


// // int[,] matrix0 = new int[3, 4];
// // PrintAray(matrix0);
// // Console.WriteLine();
// // FillAray(matrix0);
// // PrintAray(matrix0);



// int[,] pic = new int[,]
// {
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
//  {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };

// void PrintImage(int[,] image)            //  Печатаем массив. 
// {
//     for (int r = 0; r < image.GetLength(0); r++)
//     {
//         for (int t = 0; t < image.GetLength(1); t++)
//         {
//             //Console.Write($"{image[r, t]} ");
//             if (image[r,t] == 0) Console.Write($" ");
//             else Console.Write($"+");
//         }
//         Console.WriteLine();
//     }
// }


// void FillImage(int row, int col)            //  Печатаем массив. 
// {
//     if (pic[row, col] == 0)
//     {
//         pic[row, col] = 1;
//         FillImage(row - 1, col);
//         FillImage(row, col - 1);
//         FillImage(row + 1, col);
//         FillImage(row, col + 1);
//     }
// }

// PrintImage(pic);
// FillImage(13, 13);
// PrintImage(pic);




// // Факториал

// double Foctorial (int n)
// {
//     if(n == 1) return 1;
//     else return n * Foctorial(n - 1);
// }

// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Foctorial(i)}");
// }


// Фибаначи. 

// f(1) = 1
// f(2) = 1
// f(n) = f(n-) + F(n-2)


double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1; 
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine(Fibonacci(i));
}