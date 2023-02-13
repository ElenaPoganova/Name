/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int f(int m, int n)
{
    if (m == n)
        return m;
    return m + f(m + 1, n);
}


Console.Clear();
Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите последнее число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(m, n));






