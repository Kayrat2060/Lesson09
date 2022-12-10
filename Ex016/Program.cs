// Урок 9. Рекурсия
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// задача 64 ----------------------------------------

// string WriteAllInt(int n) // функция которая выводит строку состоящая из чисел от n до 1
// {
//     if (n == 1) return "1"; // условие прекращения рекурсии
//     return $"{n} " + $"{WriteAllInt(n-1)}"; // применяем рекурсию для склеивания чисел
//     // "n"+"f(n-1)"->"n"+"n-1"+"f(n-2)"->"n"+"n-1"+"n-2"+"f(n-3)"->"n"+"n-1"+"n-2"+...+"3"+"2"+"1"
// }
// Console.Write("введите N: ");
// int n = int.Parse(Console.ReadLine());
// // выводим результат на экран
// if (n >= 1) Console.WriteLine(WriteAllInt(n));
// else Console.WriteLine("n должно быть не меньше 1");

// задача 66 ----------------------------------------

// int SumOfNumbers(int m, int n) // функция которая подсчитывает сумму чисел в промежутке от m до n
// {
//     if (n > m) return m + SumOfNumbers(m + 1, n); // рекурсия если n>m
//     else if (n == m) return m;                   // условия прекращения рекурсии
//     else return n + SumOfNumbers(m, n + 1);     // рекурсия если m>n
// }
// Console.Write("введите M: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("введите N: ");
// int n = int.Parse(Console.ReadLine());
// // вывод результата на экран используя заданные пользователем m и n
// Console.WriteLine($"сумма натуральных чисел в промежутке [{m}, {n}] равна {SumOfNumbers(m, n)}");

// задача 68 ----------------------------------------
// вариант 1

decimal funcAkkerman(decimal m, decimal n) // функция Аккрмана, взял из Википедии
{
    if (m == 0) return n + 1; // условие прекращение рекурсии оно же следует из определения функции Аккермана
    else if (n == 0) return funcAkkerman(m - 1, 1); // следует из определения функции Аккермана
    return funcAkkerman(m - 1, funcAkkerman(m, n - 1)); //следует из определения функции Аккермана
}
// стандартный запрос аргументов из консоли и вывод резултата на экран вызвав нашу рекурсивную функцию
Console.WriteLine();
Console.WriteLine("Введите аргументы m и n для функции Аккермана A(m, n)");
Console.Write("m = ");
decimal m = Convert.ToDecimal(Console.ReadLine());
Console.Write("n = ");
decimal n = Convert.ToDecimal(Console.ReadLine());
decimal x = funcAkkerman(m, n);
Console.WriteLine();
Console.WriteLine($"A({m}, {n}) = {x}");
Console.WriteLine();

// вариант 2 - частично итерационный
// decimal funcAkkerman(decimal m, decimal n)
// {   // тоже взято из Википедии
//     while (m > 0)
//     {
//         if (n == 0) n = 1;
//         else n = funcAkkerman(m, n - 1);
//         m--;
//     }
//     return n + 1;
// }
// стандартный запрос аргументов из консоли и вывод резултата на экран вызвав нашу рекурсивную функцию

// Console.WriteLine();
// Console.WriteLine("Введите аргументы m и n для функции Аккермана A(m, n)");
// Console.Write("m = ");
// decimal m = Convert.ToDecimal(Console.ReadLine());
// Console.Write("n = ");
// decimal n = Convert.ToDecimal(Console.ReadLine());
// decimal x = funcAkkerman(m, n);
// Console.WriteLine();
// Console.WriteLine($"A({m}, {n}) = {x}");
// Console.WriteLine();