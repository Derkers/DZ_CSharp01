/*Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
Не использовать метод Math.Pow
3, 5 -> 243 (3⁵)
2, 4 -> 16   */

Console.WriteLine("введите число ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите степень числа ");
double b = Convert.ToDouble(Console.ReadLine());
double result = a;
if(a == 0 && b == 0)
{
    Console.WriteLine(1);
}
else 
{
    exponentiationFunction(a, b);
}



void exponentiationFunction (double a, double b)
{
for (int i = 1; i < b; i++)
{
    result = result * a;
}
Console.WriteLine($"A в степени B равно: {result}");
System.Console.WriteLine($"отрецательная степеь {1/result}");
}
