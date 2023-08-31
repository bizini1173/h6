// Задача 68: Напишите программу вычисления
//  функции Аккермана с помощью рекурсии.
//   Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackermann(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Ackermann(n - 1, 1);
    else
      return Ackermann(n - 1, Ackermann(n, m - 1));
}

int m = 3;
int n = 11;
int result = Ackermann(m, n);
Console.WriteLine($"Ackermann({m},{n}) = {result}");




