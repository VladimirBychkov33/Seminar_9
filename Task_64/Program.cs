// Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2"

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

PrintNumbers(number);

void PrintNumbers(int num)
{
    if (num == 1) return;
    else if(num % 2 == 0)
    {
        Console.Write($"{num} ");
    }
    PrintNumbers(num - 1);
}


