 /* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
 M = 1; N = 15 -> 120
 M = 4; N = 8. -> 30
 */
 

int m = ConsoleInput("Введите число M: ");
int n = ConsoleInput("Введите число N: ");

SumNaturalElements(m, n);


void SumNaturalElements(int m, int n)
{
    Console.Write(SumNatural(m - 1, n));
}



int SumNatural(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumNatural(m, n);
        return res;
    }
}


int ConsoleInput(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}








int m = ConsoleInput("Введите число M: ");
int n = ConsoleInput("Введите число N: ");

Akkerman(m,n);



void Akkerman(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}


int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}



int ConsoleInput(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
