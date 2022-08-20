Console.Clear();

// Задача 19  
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//                           14212 -> нет
//                           12821 -> да
//                           23432 -> да

Console.WriteLine("Задача 19");
Console.WriteLine();

Console.WriteLine("Введите 5 Значное число: ");

try
{
    int N = Convert.ToInt32(Console.ReadLine());
    
    // string str = N.ToString();      
    string str = Convert.ToString(N);                
    int length = str.Length;                       
    int CorrectLength = 5;

   if (CorrectLength == length)                     
   {
     if (str[0] == str[4] && str[1] == str[3])
     {
        Console.WriteLine("да");
     }
     else
     {
        Console.WriteLine("нет");
     }
   }
   else
   {
    Console.WriteLine("Введите 5 значное челое число");
   }

}
catch 
{
   Console.WriteLine("Введите Целое Число");
}
Console.WriteLine();
Console.WriteLine();



// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//                            A (3,6,8); B (2,1,-7), -> 15.84
//                            A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Задача 21");

try
{
    Console.WriteLine("Введите число кардинат 1.");
    Console.Write("x ");
    double x1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("y ");
    double y1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("z ");
    double z1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите число кардинат 2.");
    Console.Write("x ");
    double x2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("y ");
    double y2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("z ");
    double z2 = Convert.ToDouble(Console.ReadLine());

    double AB = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));   //  Math.Sqrt - Извлечения корня.
    //                                                                                    Mat.Pow  -  Возвешение в степень. ",2" - В какую. 

    Console.WriteLine(AB);
}
catch
{
    Console.WriteLine("Введите Чифрй кардинат.");
}

Console.WriteLine();
Console.WriteLine();

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//        3 -> 1, 8, 27
//        5 -> 1, 8, 27, 64, 125

Console.WriteLine("Задача 23");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Введите число N. : ");
int Q = Convert.ToInt32(Console.ReadLine());

int i = 1; 

while (i < Q + 1)
{
    if (i == Q)
     {
        Console.Write( i * i * i);
        break;
     }
     else
     {
        Console.Write(i * i * i + ", ");
        i++;
     }
     
}