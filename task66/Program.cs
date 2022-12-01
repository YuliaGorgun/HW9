// Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Введите m: ");
int m = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите n: ");
int n = int.Parse (Console.ReadLine()!);
Console.WriteLine($"Sum = {SumNumbers(m, n)}");

int SumNumbers(int m, int n)
{
    if (m == 0 || n == 0) return 0;   
    else if (m == n) return m;                      
    else if (m < n) return n + SumNumbers(m, n - 1); 
    else return n + SumNumbers(m, n + 1);            
}
