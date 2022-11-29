/* Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */


int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());

if(numberA > numberB )
{
    Console.WriteLine($"Число {numberA} больше числа {numberB}");
}
else if (numberA < numberB)
{
    Console.WriteLine($"Число {numberA} меньше числа {numberB}");
}
else 
{
   Console.WriteLine($"Число {numberA} равно числу {numberB}"); 
}