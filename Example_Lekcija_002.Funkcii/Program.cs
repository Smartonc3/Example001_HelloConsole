﻿            
            
            // Одга задача, Разние решения по поиску МАХ числа.
            
            // int Max(int arg1, int arg2, int arg3)
            // {
            //     int result = arg1;
            //     if(arg2 > result) result = arg2;
            //     if(arg3 > result) result = arg3;
            //     return result;
            // }

            // int a1 = 15;
            // int b1 = 21;
            // int c1 = 32;
            // int a2 = 12;
            // int b2 = 23;
            // int c2 = 33;
            // int a3 = 13;
            // int b3 = 23;
            // int c3 = 323;

            // // int max  =a1;
            // // if (b1 > max) max = b1;
            // // if (c1 > max) max = c1;

            // // if (a2 > max) max = a2;
            // // if (c2 > max) max = c2;
            // // if (b2 > max) max = b2;

            // // if (a3 > max) max = a3;
            // // if (c3 > max) max = c3;
            // // if (b3 > max) max = b3;

            // // int max1 = Max(a1, b1, c1);
            // // int max2 = Max(a2, b2, c2);
            // // int max3 = Max(a3, b3, c3);
            // // int max = Max(max1, max2, max3);

            // int max = Max( 
            //     Max(a1, b1, c1),
            //     Max(a2, b2, c2),
            //     Max(a3, b3, c3)
            // );

            // Console.WriteLine(max);


            // int Max(int arg1, int arg2, int arg3)
            // {
            //     int result = arg1;
            //     if(arg2 > result) result = arg2;
            //     if(arg3 > result) result = arg3;
            //     return result;
            // }


            // //  Изпользования тагоже примера через МАССИВЫ.
            // int[] array = {11,21,31,41,11235,61,17,18,19,};

            // int max = Max(
            //     Max(array[0], array[1], array[2]),
            //     Max(array[3], array[4], array[5]),
            //     Max(array[6], array[7], array[8])
            // );

            // Console.WriteLine(max);


//  Задача поиска позиции нуюного нам Элимента.  //

// int[] array = {1, 12, 31, 4, 15, 18, 16, 17, 18,};
// int n = array.Length; 
// int find = 18;
// int index = 0;

// while (index < n)
// {
//     if(array[index] == find)
//     {
//         Console.WriteLine(index);
//         break; // Означакт закончи цикл. 
//     }
//     // index = index + 1;
//     index++;
// }


// Таже задача с Элимнтамо но только с случайно сгенерированними числами. 

void FillArray1(int[] collection)    //  Наименование метода FillArray,  Аргумент - collection
{
    int length = collection.Length;  // Длина массива получаем. 
    int index = 0; 
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);   // Обрашаемся к аргументу collection на пазицию index и кладём новое случайное число 
                         // из деапазона 1 - 10. 
        index++;
    }

}

void PrintArray1(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;        
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array1 = new int[10];   // new int[10] означает создай новый масив в котором будет 10 млиментов.
array1[4] = 4;
array1[6] = 4;

FillArray1(array1);
PrintArray1(array1);

Console.WriteLine();

int pos = IndexOf(array1, 444);
Console.WriteLine(pos);