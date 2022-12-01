//Задайте значение N. Напишите программу, которая выведет все натуральные
// числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.WriteLine("Введите число, от которого нужно вывести числа: ");
int n = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите число, до которого нужно вывести числа: ");
int m = int.Parse (Console.ReadLine()!);
Console.WriteLine($"Все натуральные числа от N до 1:");

void Rec (int n, int m=1)
{
    Console.WriteLine(n);
    if (m >= n)
    { 
    Console.WriteLine();
    return;
    }
Console.WriteLine(" ");
Rec(n-1);
return;
}
Rec(n);
