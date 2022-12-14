/* Задача 3: (branch task_3)
Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33]
*/


Console.WriteLine("Введите длинну массива:");
int array = int.Parse(Console.ReadLine());

int[] randomArray = new int[array];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}


