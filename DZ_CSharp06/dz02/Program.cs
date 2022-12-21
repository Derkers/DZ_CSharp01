/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */


double b1 = ConsoleInput("введите значение b1 ");
double k1 = ConsoleInput("введите число k1 ");
double b2 = ConsoleInput("введите значение b2 ");
double k2 = ConsoleInput("введите число k2 ");

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");


int ConsoleInput(string message)  
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}