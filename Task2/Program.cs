// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

void Zadacha66()
{
    Console.Write("Введите первое число промежутка: ");
    int numbM = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число промежутка: ");
    int numbN = Convert.ToInt32(Console.ReadLine());

    if (numbM <=0 || numbN <= 0)
    {
        Console.WriteLine("Такое число не является натуральным");
    }
    else Recursion(numbM, numbN);

    void Recursion(int numbM, int numbN, int result = 0)
    {
        if (numbM > numbN)
        {
            Console.Write(result + " ");
            return;
        }
        result += numbM;
        numbM++;

        Recursion(numbM, numbN, result);
    }

}

Zadacha66();