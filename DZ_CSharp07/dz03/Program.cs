/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */



int lines = ConsoleInput("Введите количество строк ");
int columns = ConsoleInput("Введите количество столбцов ");

int[,] numbers = new int[lines, columns];
ArrayRandomNumbers(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double ArefmeticalMean = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        ArefmeticalMean = (ArefmeticalMean + numbers[i, j]);
    }
    ArefmeticalMean = ArefmeticalMean / lines;
    Console.Write(ArefmeticalMean + "; ");
}
Console.WriteLine();
ConsoleArray(numbers);





void ArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}



void ConsoleArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}



int ConsoleInput(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}