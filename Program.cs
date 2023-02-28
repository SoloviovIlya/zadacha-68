//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("Введите n и m: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int Akk(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akk(n - 1, 1);
    else
      return Akk(n - 1, Akk(n, m - 1));
}
int x = Akk(n,m);
Console.WriteLine(x);