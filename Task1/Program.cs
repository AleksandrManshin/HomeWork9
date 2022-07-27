// Задача 64: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N, кратные трём.

void Zadacha64()
{
    Console.Write("Введите первое число промежутка: ");
    int numbM = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число промежутка: ");
    int numbN = Convert.ToInt32(Console.ReadLine());

    Recursion(numbM, numbN);

    void Recursion(int numbM, int numbN, int result = 0)
    {
        if(numbM > numbN) return;

        if(numbM % 3 == 0)
        {
            Console.Write(numbM + " ");
        }
        numbM++;

        Recursion(numbM, numbN, result);
    }

}

Zadacha64();