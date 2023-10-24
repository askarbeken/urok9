// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (M > N)
{
    Console.WriteLine("M должно быть меньше или равно N");
}
else
{
    int result = CalculateSum(M, N);
    Console.WriteLine($"Сумма натуральных чисел в промежутке от {M} до {N} равна {result}");
}

int CalculateSum(int M, int N)
{
    if (M > N)
    {
        return 0;
    }
    else
    {
        return M + CalculateSum(M + 1, N);
    }
}