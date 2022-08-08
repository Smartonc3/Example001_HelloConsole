// // Первая задания 

// Console.WriteLine("Введите Первое целое число, ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Второе целое число, ");
// int b = Convert.ToInt32(Console.ReadLine());

// if (b * b == a)
// {
//     Console.WriteLine("Второе чисто квадрат первого");
// }
// else
// {
//     Console.WriteLine("Второе чисто НЕ квадрат первого");
// }


// // Второе Задания 

// Console.WriteLine("Введите целое от 1 до 7 включительно, ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n == 1)
// {
//     Console.WriteLine("Понедельник");
// }

// if (n == 2)
// {
//     Console.WriteLine("Вторник");
// }

// if (n == 3)
// {
//     Console.WriteLine("Соеда");
// }

// if (n == 4)
// {
//     Console.WriteLine("Четверг");
// }

// if (n == 5)
// {
//     Console.WriteLine("Пятница");
// }

// if (n == 6)
// {
//     Console.WriteLine("Суббота");
// }

// if (n == 7)
// {
//     Console.WriteLine("воскресения");
// }
// else
// {
//     Console.WriteLine("Введите числа от 1 до 7 Включительно");

// }


// // Второе Задания Способ решения "switch" 

// Console.WriteLine("Введите целое от 1 до 7 включительно решения switch, ");
// int m = Convert.ToInt32(Console.ReadLine());

// switch (m)
// {
// case 1:
//     {
//         Console.WriteLine("Понедельник");
//         break;
//     }

// case 2:
//     {
//         Console.WriteLine("Вторник");
//         break;
//     }

// case 3:
//     {
//         Console.WriteLine("Соеда");
//         break;
//     }

// case 4:
//     {
//         Console.WriteLine("Четверг");
//         break;
//     }

// case 5:
//     {
//         Console.WriteLine("Пятница");
//         break;
//     }

// case 6:
//     {
//         Console.WriteLine("Суббота");
//         break;
//     }

// case 7:
//     {
//         Console.WriteLine("воскресения");
//         break;
//     }
// }



// Задача по промежутку

Console.WriteLine("Введите число для 3 задачи, "); 
int s = Convert.ToInt32(Console.ReadLine());
s = - s;
int x = s;
s = -x;
Console.Write(x);
Console.Write(",");

while (x < s -1)
{
    x = x + 1;
    Console.Write(x);
    Console.Write(",");
} 
Console.WriteLine(s);


// Решение этой же задачи преподователем. 

int e = 0;
Console.WriteLine( "Введите число E Решение преподователя" );
e = Convert.ToInt32(Console.ReadLine());
for (int i = -e; i <= e; i++)
{
    Console.Write( i + " ");
}


Console.ReadLine();

// //Задача по введению 3 значного числа и выдача послеггего. 

// Console.WriteLine("Введите трёх значное число, "); 
// string q = Console.ReadLine();
// Console.WriteLine(q[2]);



// Console.WriteLine("Введите трёх значное число, способ 2 "); 
// int w = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(q[2]);


// // Задача по введению 3 значного числа и выдача послеггего. Решение преподователя

// int t = 0;
// Console.WriteLine("Введите трёх значное число, Решение преподователя:" );
// t = Convert.ToInt32(Console.ReadLine());
// if (t >= 100 && t <= 999)
// {
//     int lastDigit = t % 10;
//     Console.WriteLine("Последное цейра числа = " + lastDigit);
// }
// else
// {
//     Console.WriteLine("Это не трёх значное число!");
// }