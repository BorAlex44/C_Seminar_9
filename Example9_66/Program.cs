using static System.Console;
Clear();
Write("Введите первое число: ");
int num1 = int.Parse(ReadLine()!);
Write("Введите второе число: ");
int num2 = int.Parse(ReadLine()!);
WriteLine($"Сумма чисел в диапазоне от {num1} до {num2} равна {GetNumberSumma(num1, num2)}");



int GetNumberSumma(int m, int n)
{
    if (m == n) return n;
    return n + GetNumberSumma(m, n - 1);
}