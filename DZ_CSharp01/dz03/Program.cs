/* Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет  */

Console.Write("Ведите число ");
int numberA = int.Parse(Console.ReadLine());
//int result = numberA % 2 ;

if (numberA % 2 == 0) 
{
    Console.WriteLine("Число является четным ");
}
else 
{
    Console.WriteLine("Число является нечетным ");
}