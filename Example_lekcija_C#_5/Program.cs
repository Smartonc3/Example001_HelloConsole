Console.Clear();


// //  Задать Массив из 12 элиментов, Заполнить рандовно от -9 до 9:
// // Выяснить умму всех положительнызх и всех отрицательных чисел. 

// int[] Array = new int[12] ;
// int length = Array.Length;  
// int i = 0; 
// Random rnd = new Random();                  
// while (i < length)             //  Заполнаем Массив

// {
//     Array[i] = rnd.Next(-9,10);  
//     Console.Write(Array[i] + " ");
//     i++;   
// }
// Console.WriteLine();

// // Console.WriteLine(array[i]);


// // int[] Array = new int[12];
// // Random rnd = new Random(); //подключаем случайные числа
// // for (int i=0; i<12; i++)
// // {
// // Array[i] = rnd.Next(-9,9);
// // Console.Write($"{Array[i]} ");
// // }
// // Console.WriteLine();

// int positive = 0;
// int negativ = 0;

// for (int i1 = 0; i1 < length; i1++)        
// {  
//     if (Array[i1] < 0)
//     {
//         negativ += Array[i1];
//     }
//     else
//     {
//         positive += Array[i1]; 
//     }
// }
// Console.WriteLine("Негативный " + negativ );
// Console.WriteLine("Положительних " + positive );


// // -----------------------------------------------------------------------------------------------------------------------


// // Задача 32. Написвть программу Замены Элиментов в Массиве. Положительные на отрицательные и Отрицательные на положительные. 
// // [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] array = new int[7];
// int len = array.Length;
// int q = 0;
// Random w = new Random();

// Console.Write("Элимент:     ");
// while (q < len)
// {
//     array[q] = w.Next(-9,10);
//     Console.Write(array[q] + " ");
//     q++;
// }
// Console.WriteLine("");
// Console.WriteLine("");

// int r = 0; 
// int Turn = 0;
// Console.Write("Элимент с - : ");
// while (r < len)
// // {
// //     Turn = array[r] * -1;
    
// //     Console.Write(Turn + " ");
// //     r++;
// // }
// {
//     array[r] *= -1;
    
//     Console.Write(array[r] + " ");
//     r++;
// }


// // Задача 32. Написвть программу Замены Элиментов в Массиве. Положительные на отрицательные и Отрицательные на положительные. 
// // [-4, -8, 8, 2] -> [4, 8, -8, -2]
// // Метод приподователя. 

// int[] array = {1, 2, 3, 4};
// int len = array.Length;

// Console.WriteLine();
// Console.Write("Изменённый массив: ");

// for (int i = 0; i < len; i++)
// {
//     array[i] *= -1;
//     Console.Write(array[i] + " ");
// }




// // // Задача 32. Написвть программу Замены Элиментов в Массиве. Положительные на отрицательные и Отрицательные на положительные. 
// // // [-4, -8, 8, 2] -> [4, 8, -8, -2] 
// // // Рещение Сокурскина

// void FillAray (int [] arr)
// {
//     int length = arr.Length;
//     for (int i = 0; i < length; i++)
//     {
//         arr[i] = new Random().Next (-100,100);
//         Console.Write(arr [i] + " ");         //  Фаменает Функцию печати внизу.
//     }
// }

// // void PrintAray (int [] arr)                       //   Можно не вводитью Метолд Печати.  
// // {
// //     int length = arr.Length;
// //     for (int i = 0; i < length; i++)
// //     {   
// //         Console.Write(arr [i] + " ");
// //     }
// // }

// int [] array = new int [10];

// FillAray(array);
// // PrintAray(array);

// Console.WriteLine();
// for (int i = 0; i < array.Length; i++)
// {
//     array [i] = - array [i];
//     Console.Write(array[i] + " ");
// }

// // PrintAray(array);

// // -----------------------------------------------------------------------------------------------------------------------


// // Задача 33. Написать программу Которая определает присуствует ли заданное число в Массиве. 
// //  4  ->  [6, 5, 7, 6, 2] нет
// //  5  ->  [6, 8, 5, 7, 1] да


// int[] array = new int[7];
// int len = array.Length;
// int q = 0;
// Random w = new Random();
// Console.Write("Элимент:     ");
// while (q < len)
// {
//     array[q] = w.Next(-9,10);
//     Console.Write(array[q] + " ");
//     q++;
// }
// Console.WriteLine("");
// Console.WriteLine("");

// Console.WriteLine("Введите проверечное число: ");
// int Q = Convert.ToInt32(Console.ReadLine());

// int i = 0;

// while (i < len)
//     {
//         if (Q != array[i])
//         {
//             i++;
//             if (i == len)
//             {
//                 Console.WriteLine("число нет: ");
//                 break;
//             }
//         }
//         if (Q == array[i])
//         {
//             Console.WriteLine("число есть: ");
//             break;
//         }
//     }


// // Задача 33. Написать программу Которая определает присуствует ли заданное число в Массиве. 
// //  4  ->  [6, 5, 7, 6, 2] нет
// //  5  ->  [6, 8, 5, 7, 1] да
// // Решение прнподователя. 

// int[] array = {1, 2, 3, 4};
// Console.WriteLine("Введиче число");
// int elem = Convert.ToInt32(Console.ReadLine());
// int len = array.Length;
// bool isThere = false;

// for (int i = 1; i < len; i++)
// {
//     if (array[i] == elem)
//     {
//         isThere = true;
//     }
// }

// if (isThere)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("нет");
// }




// // Задача 33. Написать программу Которая определает присуствует ли заданное число в Массиве. 
// //  4  ->  [6, 5, 7, 6, 2] нет
// //  5  ->  [6, 8, 5, 7, 1] да
// // Решение сокурсника. 

// void FillAray (int [] arr)
// {
//     int length = arr.Length;
//     for (int i = 0; i < length; i++)
//     {
//         arr[i] = new Random().Next (-100,100);
//         Console.Write(arr [i] + " ");      //  Фаменает Функцию печати внизу. 
//     }
// }

// // void PrintAray (int [] arr)                    //   Можно не вводитью 
// // {
// //     int length = arr.Length;
// //     for (int i = 0; i < length; i++)
// //     {   
// //         Console.Write(arr [i] + " ");
// //     }
// // }

// int [] array = new int [10];

// FillAray(array);
// // PrintAray(array);
// Console.WriteLine();

// Console.WriteLine("Введите число");
// int a = int.Parse(Console.ReadLine());
// int var = 0; 

// for (int i = 0; i < array.Length; i++)
// {
//     if (a == array[i])
//     {
//         Console.WriteLine("Число присуствует");
//         var ++;
//         break;
//     }
// }

// if (var == 0)
// {
//     Console.WriteLine("Число не присуствует");
// }



// // Задание 35: 
// // Задать массив из 123 случайных чисел. Найти количество элиментов в деопозоне от 10 до 99:

// void FillAray (int [] arr)
// {
//     int length = arr.Length;
//     for (int i = 0; i < length; i++)
//     {
//         arr[i] = new Random().Next (-100,300);
//         Console.Write(arr [i] + " "); 
//     }
// }

// int[] arrey = new int[123];
// FillAray(arrey);
// Console.WriteLine();
// int caunt = 0; 
// int len = arrey.Length;
// // int i = 0;

// for (int i = 0; i < len ; i++)
// {
//     if (arrey[i] > 10 & arrey[i] < 99)
//     {
//         caunt++;
//     }
// }
// Console.WriteLine();
// Console.WriteLine(caunt + " Сумма");

// // while ( i < len)
// // {
// //     if (arrey[i] > 10 && arrey[i] < 99)
// //     {
// //         caunt++;
// //         i++;
// //     }
// //     else
// //     {
// //         i++;
// //     }
// // }

// // Console.WriteLine();
// // Console.WriteLine(caunt + " Сумма");

// // ---------------------------------------------------------------------------------------------------------------------

// Задание 37: 
// Найти произведение пар в массиве. Пара это первый и последниц, второй и пледпоследний, И т.д.
// [1 2 3 4 5 ] -> 5 8 3 
// [6 7 3 6] -> 3 6 21


void FillAray (int [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next (-100,300);
        Console.Write(arr [i] + " "); 
    }
}

int[] arrey = new int[12];
FillAray(arrey);
Console.WriteLine();
// int caunt = 0; 
int len = arrey.Length;
int i = 0;
int q = len -1;
int sum1 = 0;


while (i < len / 2)
{
    sum1 = arrey[i] + arrey[q]; 
    Console.WriteLine(sum1);
    i++;
    q = q -1;

}
