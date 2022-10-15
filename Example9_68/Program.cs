using static System.Console;
Clear();
Write("Введите число m: ");
int num1 = int.Parse(ReadLine()!);
Write("Введите число n: ");
int num2 = int.Parse(ReadLine()!);
WriteLine($"Результат вычисления функции Аккермана для чисел: {num1} и {num2} равен {GetAkkerman(num1, num2)}");


int GetAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return GetAkkerman(m - 1, 1);
    else return GetAkkerman(m - 1, GetAkkerman(m, n - 1));
}