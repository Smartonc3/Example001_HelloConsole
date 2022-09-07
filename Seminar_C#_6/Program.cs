
// // // Рекурсия   

// // //  Собрать страку с числами от a до b, a <= b;

//        //  Итнерактивный подход задачи. 

// string NumbersFor(int a, int b)      //  Задаём массив
// {
//     string result = string.Empty;   //  Определили Пустую строку.
//     for (int i = a; i <= b; i++)    //  Заполнаем пустую строку. 
//     {
//         result += $"{i} ";          //  Собираем в страку result канкретное значения счётчика. 
//     }
//     return result;                  //  Возврашаем Страку. 
// }


//        //  Рекурсионный способ. 

// string NumbersRec(int a, int b)     //   задаём массив 
// {
//     if (a <= b) return $"{a} " + NumbersRec(a + 1, b);     // Если a <= b то мы собираем текушую значение a и вызаваем новую копию
//                                                            // метолда но значением оргументоа а увеличенный на 1. 
//     else return String.Empty;      //  Возврашаем пустую строку в слцчии если условия не выполнилась. 
// }

// Console.WriteLine(NumbersFor(1, 10));    //  Вводим значения в массив и вводим на экран
// Console.WriteLine(NumbersRec(1, 10));    





// // //  Собрать страку с числами от a до b, a => b;

//        //  Итнерактивный подход задачи. 

// string NumbersFor(int a, int b)      //  Задаём массив
// {
//     string result = string.Empty;   //  Определили Пустую строку.
//     for (int i = a; i >= b; i--)    //  Заполнаем пустую строку. 
//     {
//         result += $"{i} "; 
//         // Console.WriteLine(result);
//     }
//     return result;                  //  Возврашаем Страку. 
// }


       //  Рекурсионный способ. 

// string NumbersRec(int a, int b)     //   задаём массив 
// {
//     if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";     // Если a <= b то мы собираем текушую значение a и вызаваем новую копию
//                                                            // метолда но значением оргументоа а увеличенный на 1. 
//     else return String.Empty;      //  Возврашаем пустую строку в слцчии если условия не выполнилась. 
// }

// Console.WriteLine(NumbersFor(1, 10));    //  Вводим значения в массив и вводим на экран
// Console.WriteLine(NumbersRec(1, 10));    





// // // Сумма чисел от 1 до n: 

//     //  Итнерактивный подход задачи.

// int SumFor(int n)        //  Создаём функцию
// {
//     int result = 0;      //  создаём переменную
//     for (int i = 0; i <= n; i++) result += i;    // Вводим цикл дге в переменую result кладём сумму чисел. 
//     return result;       //  Возврашаем result
// }

//     //  Рекурсионный способ.

// int SumRec(int n)
// {
//     if (n == 0) return 0;     //   Условие Выхода.  n = 0
//     else return n + SumRec(n - 1);      //  Берём n и прибовлаем к нему n - 1
// } 

// Console.WriteLine(SumFor(10));
// Console.WriteLine(SumRec(10));


// // // Факториал чисел: 

//     //  Итнерактивный подход задачи.

// int FactorialFor(int n)        //  Создаём функцию
// {
//     int result = 1;      //  создаём переменную
//     for (int i = 1; i <= n; i++) result *= i;    // Вводим цикл дге в переменую result кладём умножения чисел. 
//     return result;       //  Возврашаем result
// }

//     //  Рекурсионный способ.

// int FactorialRec(int n)
// {
//     if (n == 1) return 1;     //   Условие Выхода.  n = 0
//     else return n * FactorialRec(n - 1);      //  Берём n и умножаем к нему n - 1
// } 

// Console.WriteLine(SumFor(10));
// Console.WriteLine(SumRec(10));




// // // Вычислить a в степени n. a^n

// //     //  Итнерактивный подход задачи.

// int PowerFor(int a, int n)    //  Создаём функцию
// {
//     int result = 1;           //  создаём переменную
//     for (int i = 1; i <= n; i++) result *=a;     
//     return result;
// }


//     //  Рекурсионный способ.


// int PowerRec(int a, int n)
// {
//     if (n == 0) return 1;
//     else return PowerRec(a, n - 1) * a;
// }

// int PowerRecMat(int a, int n)
// {
//     if (n == 0) return 1;
//     else if (n % 2 == 0) return PowerRecMat(a * a, n /2 );
//     else return PowerRecMat(a, n - 1) * a;
// }

// Console.WriteLine(PowerFor(2, 10));
// Console.WriteLine(PowerRec(2, 10));
// Console.WriteLine(PowerRecMat(2, 10));





// // Передор слов. 
// //  Есть 4 буквы.  "а" "и" "с" "т". Показать все слова состояшие из Т букв, которые можно построить из этого альфавита.

//  //  Итнерактивный подход задачи.


//  char[] s = {'а', 'и', 'с', 'в'};    // Массив сиволов

// int count = s.Length;
// int n = 1;

// for (int i = 0; i < count; i++)
// {
//     for (int j = 0; j < count; j++)
//         {
//             for (int k = 0; k < count; k++)
//                 {
//                    for (int l = 0; l < count; l++)
//                     {
//                         for (int m = 0; m < count; m++)
//                             {
//                                 Console.WriteLine($"{n++, -5}{s[i]}{s[j]}{s[k]}{s[l]}{s[m]}");
//                             }
//                     }
//                 }
//         }
// }





//     //  Рекурсионный способ.
//     //  Собрать все слова. 

// int n = 1;   //  Счётчик слов 
// void FindWords(string alphabet, char[] word, int length = 0)     //  метод принимает алфовит. В данном случаи стракой 
//                //  массив из буков с помошю которого будем состовлять новое слово,  Собираем длину этого слова на 
//                // текушей итерации. 
// {
//     if (length == word.Length)     // Условыя выхода из рекурси. 
//     {
//         Console.WriteLine($"{n++} {new String(word)}"); return;
//     }
    
//     for (int i = 0; i < alphabet.Length; i++)
//     {
//         word[length] = alphabet[i];
//         FindWords(alphabet, word, length +1);
//     }
// }

// FindWords("аисв", new char[5]);




// // -----------------------------------------------------------------------------------------------------------------------



// // Олгоритм обхода дериктория. 


// string path = "C:/Users/g3/Desktop/Домашние Задания";
// DirectoryInfo di = new DirectoryInfo(path);
// System.Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles();

// for (int i = 0; i < fi.Length; i++)
// {
//     System.Console.WriteLine(fi[i].Name);
// }


// //  -------------------------------------------------------------------------------------

// // Рекурися которая ходит по папкам и выдаёт что в них. 


// void CatalogInfo(string path, string indent = "")     // Метот CatalogInfo, Аргументы string path - путь к текушей папкеб
//                      //   string indent = ""  - изкуственный приём позволаюший видить структурк папки. 
// {
//     DirectoryInfo catalog = new DirectoryInfo(path);     //  инфо о деректории в которую зашли. по пути path

//     DirectoryInfo[] catalogs = catalog.GetDirectories();    //  Получаем массив всех файлов находяшийся в этой папке.
//     for (int i = 0; i < catalogs.Length; i++)               //  Пробигаем по ним
//     {
//         Console.WriteLine($"{indent}{catalogs[i].Name}");   //  И выводя инфо о текушум каталоге
//         CatalogInfo(catalogs[i].FullName, indent + " ");   // И рекурсивно занириваем и просматриваем все папки получанные
//                                                           // на этапе DirectoryInfo[] catalogs
//     }
    
//     FileInfo[] files = catalog.GetFiles();
//                                                          //  Закончили вывод папок.

//                     //  Получаем весь список файлов текушей директории, текушего каталога

//     for (int i = 0; i < files.Length; i++)                   // Показываем их
//     {
//         Console.WriteLine($"{indent}{files[i].Name}");
//     }
// }
// string path = @"C:/Program Files";        // Путь дериктории
// CatalogInfo(path);



// //  ----------------------------------------------------------------------------------------------------


// // Игра в пирамидки


void Towers(string with = "1", string on = "3", string some = "2", int count = 3)   // string with = "1" - Рабочий шпиль.
                                                       //  string on = "3"  -  тот шпиль на котором Должна оказаться пирамида.
                                                       //  tring some = "2" -  промежуточный шпиль.
                                                       //  int count = 3   -  каличество блинов.
{
 if (count > 1) Towers(with, some, on, count - 1);
 Console.WriteLine($"{with} >> {on}");
 if (count > 1) Towers(some, on, with, count - 1);
}

Towers();

