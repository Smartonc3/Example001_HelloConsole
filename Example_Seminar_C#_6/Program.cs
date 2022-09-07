Console.Clear();

// // Записать программу которая перевернёт массив. 
// // [1 2 3 4 5] -> [5 4 3 2 1]

// int[] ReversArray(int[] input)
// {
//     int[] result = new int[input.Length];

//     for(int i = 0, j = input.Length - 1; i < input.Length; i++, j--) 
//     {
//         result[i] = input[j];
//     }

//     return result;
// }

// void PrintArray(int[] input)
// {
//     for (var i = 0; i < input.Length; i++)
//         Console.Write(input[i] + ", ");
// }

// int[] input = new int[] {1, 2, 3, 4, 5};

// var result = ReversArray(input);
// PrintArray(result);


// // Задача 40: Написать программу, которая принимает на входе 3 числа и проверает может ли 
// //   сушествовать трёхугольник с сторонами токой длины. 
// //  Теория, Каждая сторона трёхугольника меньше суммы двух других старон. 


int n = 3;
int caunt = 1;
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
Console.WriteLine($"Введите {caunt} длину Трёхугольника");
caunt ++;
array[i] = int.Parse(Console.ReadLine());
}

 if (array[0] < array[1] + array[2] &
    array[1] < array[0] + array[2] &
    array[2] < array[0] + array[1] 
    )
    {
        Console.WriteLine("Трёх угольник сушествует ");

    }
    else
    {
        Console.WriteLine("Трёх угольник не сушествует ");

    }



// // Задача 40: Написать программу, которая принимает на входе 3 числа и проверает может ли 
// //   сушествовать трёхугольник с сторонами токой длины. 
// //  Теория, Каждая сторона трёхугольника меньше суммы двух других старон. 
// // Решение Сокурсника


bool IsTriang(int A, int B, int C)
{
    if (A < B + C & B < A + C & C < A + B)
    {
        return true;
    }
    return false;
}

Console.WriteLine("A");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("B");
int B = int.Parse(Console.ReadLine());

Console.WriteLine("С");
int C = int.Parse(Console.ReadLine());

if (IsTriang(A, B, C ))
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ ");
}



// 42 Предброзовать десятичное число в двоичную систеиу. 
// 45 - 101101
// 3 - 11
// 2 - 10

strong DecimalToBinary(int input) {
    var result = string.Empty:
    
    while (input / 2 > 0)
    {
        result += int
    }

    return result;
}

Console.WriteLine("Введите 10-чное число");
if (!int.TryParse(Console.ReadLine()!, out var number)) 
{
    Console.WriteLine("Всё плохо");
}

var result = DecimalToBinary(number);

Console.WriteLine("Двоичное представление числа " + number + " Есть число " + result);

