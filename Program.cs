// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// ******************Задача 1************************
// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());

// string Printnumber (int start, int end)
// {
//     if (start==end)
//     {
//         return start.ToString();
//     }
// return (start+" "+Printnumber(start-1,end));
// }
// Console.WriteLine(Printnumber(num,1));
// **************Конец**************************
// **************Задача 2**********************
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// Console.WriteLine("Введите N:");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите M:");
// int M = Convert.ToInt32(Console.ReadLine());

// int Sumnum(int start, int end)
// {
//     int sum=0;
//     if (start==end)
//     {
//         return sum+end;
//     }
//     if(start>end)
//     {
//         int temp=0;
//         temp=start;
//         start=end;
//         end=temp;
//     }
//     sum=start+Sumnum(start+1,end);
//     return sum;
// }
// Console.WriteLine(Sumnum(N,M));
// **********************Конец**********************
// **********************Задача 3********************
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.WriteLine("Введите m:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите n:");
// int n = Convert.ToInt32(Console.ReadLine());

// int AkkermanF(int m, int n)
// {
//     if (m==0)
//     {
//         return n+1;
//     }
//     else if (m>0 && n==0)
//     {
//         return AkkermanF (m-1,1);
//     } 
//     else 
//     {
//         return (AkkermanF(m - 1, AkkermanF(m, n - 1)));
//     }
// }
// Console.WriteLine(AkkermanF(m,n));
// ****************Конец****************************