Console.Clear();


// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
Console.WriteLine();

void FillAray (int [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next (100,999);
        Console.Write(arr [i] + " "); 
    }
}

int[] array = new int[8];
FillAray(array);
int length = array.Length;
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) 
    count++;
}
Console.WriteLine(" ");
Console.WriteLine("Количество четных значений: " + count);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine();
Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами.");
Console.WriteLine();

void FillAray1 (int [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next (-100,999);
        Console.Write(arr [i] + " "); 
    }
}

int[] arrey = new int[4];
FillAray1(arrey);
Console.WriteLine();
int lengthe = arrey.Length;
int count1 = 0; 

for (int i = 0; i < lengthe; i++)
{
    if (i % 2 != 0)
    {
        count1 = count1 + arrey[i];
    }
}

Console.WriteLine(" ");
Console.WriteLine("Сумму элементов, стоящих на нечётных позициях: " + count1);


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
Console.WriteLine();
int[] array1 = new int[6];
FillAray1(array1);
Console.WriteLine();

int max = array1[0];
int min = array1[0];

for (int i = 0; i < array1.Length; i++)
{
    if (max < array1[i]) 
    {
       max = array1[i]; 
    }
    
    if (array1[i] < min) 
    {
        min = array1[i];
    }

}
Console.WriteLine(" ");
Console.WriteLine("max = " + max);
Console.WriteLine("min = " + min);
Console.WriteLine("Разница между массивами: " + (max - min));

