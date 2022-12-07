//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());

Console.Write($"{AkermanFunct(m, n)} ");

int AkermanFunct(int n, int m)
{
  if ((n == 1) && (m == 1))
    return 1;
  else
    if (n > 1)
      return AkermanFunct(n - 1, m) + m;
    else
      return AkermanFunct(n, m - 1) + 1;
}
