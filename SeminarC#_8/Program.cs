//  //  Задать 2 мерный массив. Написать программу которая поменает местами первую и последную страку. 


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

// void Swap(int[,] arr) 
// {
//     for (int j = 0; j < arr.GetLength(1) -1; j++)
//     {
//         int temp = 0; 
//         temp = arr[0, j];
//         arr[0, j] = arr[arr.GetLength(0) -1, j];
//         arr[arr.GetLength(0) -1 , j] = temp;
//     }
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

// FillAray(array);
// Swap(array);
// Print(array);



// // Задать двухмерный массив котора менает страку на столбцу. 
// // 123        14
// // 456        25
// //            36


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

// int[,] Transverse(int[,] arr)
// {
//     int[,] arr1 = new int[n, m];
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++ )
//         {
//             arr1[j, i] = arr[i, j];
//         }
//     }
//     return arr1;
// }



// FillAray(array);
// Print(Transverse(array));
// Console.WriteLine();
// Print(array);


// // Задать 2 мерный массив из 4 чисел. Напишите программу которая удалит страку и сталбец, на пересечении которых 
// // располоден неименниий элимент массива.    
                   // //  Наименьший элимент это 1 
// // 1 4 7 2       9 2 3  
// // 5 9 2 3       4 2 4
// // 8 4 2 4       2 6 7
// // 5 2 6 7



int m = Convert.ToInt32(new Random().Next(4, 4));
int n = Convert.ToInt32(new Random().Next(4, 4));

int[,] array = new int[m, n];

void FillAray(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
            if(arr[i, j] < 0) Console.Write(arr[i, j] + " ");
            else Console.Write(" " + arr[i, j] + " "); 
            // Console.Write(mart[i,j] + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Print(int[,] mart)                          
{
   for (int i = 0; i < mart.GetLength(0); i++)
    {
        for (int j = 0; j <mart.GetLength(1); j++)
        {
            if(mart[i, j] < 0) Console.Write(mart[i, j] + " ");
            else Console.Write(" " + mart[i,j] + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    Console.WriteLine();
}


FillAray(array);
Console.WriteLine();

void FindMinArray( int[,] arr, out int row, out int col)
{
    int min = arr [0,0];
    row = 0;
    col = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++ )
        {
            if (arr [i,j] < min) 
            {
                min = arr [i, j];
                row = i;
                col = j;
            }
        }
    }
}

int x = 0, y = 0;
FindMinArray(array, out x, out y);

Console.WriteLine(x);
Console.WriteLine(y);


int[,] Transverse(int[,] arr, int row, int col)
{
    int[,] arr1 = new int[arr.GetLength(0)-1, arr.GetLength(1)-1];
    int shifti = 0;
    int shiftj = 0;
    for (int i = 0; i < arr.GetLength(0)-1; i++)
    {
        for (int j = 0; j < arr.GetLength(1)-1; j++ )
        {
            if (i < row) shifti =  0;
            else shifti = 1;

            if (j <  col) shiftj = 0; 
            else shiftj = 1;
            arr1[i, j] = arr[i + shifti, j + shiftj];
        }
    }
    return arr1;
}


Print(Transverse(array, x, y)); 


