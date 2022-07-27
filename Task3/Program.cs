// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

void Zadacha68()
{
    Console.Write("Введите число m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число n: ");
    int n  = Convert.ToInt32(Console.ReadLine());

    if (m < 0 || n < 0)
    {
        Console.WriteLine("Числа не должны быть отрицательными");
    }
    else Recursion(m, n);

    int Recursion(int m, int n)
    {
        if (m == 0) return n + 1;
        if (m != 0 && n == 0) return Recursion(m - 1, 1);
        if (m > 0 && n > 0) return Recursion(m - 1, Recursion(m, n - 1));
        return Recursion(m, n);
    }

    Console.WriteLine(Recursion(m, n));

}

Zadacha68();