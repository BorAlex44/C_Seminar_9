using static System.Console;
Clear();
Write("Введите число n > 0: ");
int number = int.Parse(ReadLine()!);
GetNumbers(number);



void GetNumbers(int n)
{
    if (n == 1) WriteLine(n);
    else
    {
        Write($"{n} ");
        GetNumbers(n - 1);
    }
}