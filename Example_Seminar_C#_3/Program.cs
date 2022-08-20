
// Console.Clear();

// Console.WriteLine("Введите Х: ");
// int r = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите Y: ");
// int Y = Convert.ToInt32(Console.ReadLine());

// if (r > 0 && Y > 0)
// {
//     Console.WriteLine("1-я четверть" );
// }
// if (r < 0 && Y > 0)
// {
//     Console.WriteLine("2-я четверть" );
// }
// if (r < 0 && Y < 0)
// {
//     Console.WriteLine("3-я четверть" );
// }
// if (r > 0 && Y < 0)
// {
//     Console.WriteLine("4-я четверть" );
// }



// // Задания 18:  Программа которая по заданному номеру четверти показывает диапазон возможниых кординат.
// Console.WriteLine("Программа которая по заданному номеру четверти показывает диапазон возможниых кординат. : ");

// int i = 0;

// while (i < 3)
// {
// Console.WriteLine("Введите число кардинат. : ");
// int E = Convert.ToInt32(Console.ReadLine());
// if (E > 0 | E < 5)

// {
//     if (E == 1)
//     {
//         Console.WriteLine("Деапазон Точек равен r > 0, и Y > 0" );
//         break;
//     }
//     if (E == 2)
//     {
//         Console.WriteLine("Деапазон Точек равен r > 0, и Y < 0" );
//         break;
//     }
//     if (E == 3)
//     {
//         Console.WriteLine("Деапазон Точек равен r < 0, и Y < 0" );
//         break;
//     }
//     if (E == 4)
//     {
//         Console.WriteLine("Деапазон Точек равен r > 0, и Y < 0" );
//         break;
        
//     }
//     i++;
    
//     if ( i > 2)
//         {
//             Console.WriteLine("Вы вели 3 раза не правильно." );
//         }
// }
// }


// // Решения однокурсника

// Console.WriteLine("Введите нмер чеьверт От 1 до 4 ");
// int count1 = 0;
// while (count1 < 5)
// {
//     try
//     {
//         int r = int.Parse(Console.ReadLine());

//         string [] q1 = {"r > 0 и y > 0", "r < 0 и y > 0,", "r < 0 и y < 0", "r > 0 и y < 0"};
//         Console.WriteLine("Деапазон значений для четверти " + r + " равен " + q1[r-1]);
//         break;
//     }
//     catch
//     {
//         Console.WriteLine("От 1 до 4. ");
//         Console.WriteLine();
//         count1
//          ++;
//         if (count1 == 5)
//         {
//             Console.WriteLine("Ты изчерпал попытки");
//         }
//     }
// } 



// Написать Программу, которая принимает на взод кординаты двух точек и находит расстояния между ними в 2D пространстве. 
//                           A (3,6) B(2,1)  -  5.06
//                           A (7,-5) B(1,-1) - 7.21


Console.WriteLine("Введите число кардинат. : ");
int ax = Convert.ToInt32(Console.ReadLine());
int ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число кардинат. : ");
int bx = Convert.ToInt32(Console.ReadLine());
int by = Convert.ToInt32(Console.ReadLine());

double AB = Math.Sqrt(Math.Pow(ax-bx,2) + Math.Pow(ay-by,2));   //  Math.Sqrt - Извлечения корня.
//                                                                  Mat.Pow  -  Возвешение в степень. ",2" - В какую. 

Console.WriteLine(AB);

// // Написать программу которая на вход число N и выдаёт таблицу квадратов чисел от 1 до N.
// //  5 -> 1, 4, 9, 19, 25
// //  2 ->  1, 4

// Console.WriteLine("Введите число N. : ");
// int N = Convert.ToInt32(Console.ReadLine());

// int i = 1; 

// while (i < N + 1)
// {
//     if (i == N)
//      {
//         Console.Write( i * i );
//         break;
//      }
//      else
//      {
//         // Console.Write($"{i * i}, " );
//         Console.Write(i * i + ", ");
//         i++;
//      }
     
// }

