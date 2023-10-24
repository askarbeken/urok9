// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

void PrintNaturalNumbers(int N)
{
    if (N >= 1)
    {
        Console.WriteLine(N);
        PrintNaturalNumbers(N - 1);
    }
}

Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 1)
{
    Console.WriteLine("N должно быть натуральным числом или больше 1");
}
else
{
    Console.WriteLine($"Натуральные числа в промежутке от {N} до 1:");
    PrintNaturalNumbers(N);
}





