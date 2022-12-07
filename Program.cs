// Задача 47. Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void Task_47()
{
    Random rand = new Random();
    int rows = rand.Next(3,10);
    int columns = rand.Next(3,10);
    double[,] DoubleArray = new double[rows, columns];
    FillDoubleArray(DoubleArray);
    Console.WriteLine("Случайный массив:");
    PrintDoubleArray(DoubleArray);
    Console.WriteLine();
}

void FillDoubleArray(double[,] DoubleNumbers)
    {
        Random rand = new Random();
        int rows = DoubleNumbers.GetLength(0);
        int columns = DoubleNumbers.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                DoubleNumbers[i, j] = rand.NextDouble() * (10 - 3) + 3;
            }
        }
    }

void PrintDoubleArray(double[,] DoubleNumbers)
{
    int rows = DoubleNumbers.GetLength(0);
    int columns = DoubleNumbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{Math.Round(DoubleNumbers[i, j], 1)}\t");
        }
        Console.WriteLine();
    }
}
Task_47();

// Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 3 -> 3

void Task_50()
{
    Random rand = new Random();
    int rows = rand.Next(3,10);
    int columns = rand.Next(3,10);
    int[,] Array = new int[rows, columns];
    FillArray(Array, 3, 10);
    
    Console.Write("Введите индекс строки: ");
    int searchI = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите индекс столбца: ");
    int searchJ = Convert.ToInt32(Console.ReadLine());

    if (searchI < rows && searchJ < columns)
    {
        Console.WriteLine(String.Empty);   
        Console.WriteLine($"Нашёл! Искомый элемент: {Array[searchI, searchJ]}.");
    }
    else
    {
        Console.WriteLine("ERROR: Index was out of range.");
    }

    Console.WriteLine(String.Empty);
    Console.WriteLine("А вот и сам массив:");
    PrintArray(Array);
}

void FillArray(int[,] numbers, int minValue, int maxValue)
    {
        maxValue++;
        Random rand = new Random();
        int rows = numbers.GetLength(0);
        int columns = numbers.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                numbers[i, j] = rand.Next(minValue, maxValue);
            }
        }
    }

void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{numbers[i, j]}\t");
        }
        Console.WriteLine(String.Empty);
    }
    Console.WriteLine(String.Empty);
}
Task_50();

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 5 3
// 8 4 6 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 6; 3.

void Task_52()
{
    Random rand = new Random();
    int rows = rand.Next(3, 10);
    int columns = rand.Next(3, 10);
    int[,] Array = new int[rows, columns];
    FillArray(Array, 3, 10);
    Console.WriteLine("Сгенерированный массив: ");
    PrintArray(Array);
    Console.WriteLine(String.Empty);

    decimal[] average = new decimal[columns];

    Console.WriteLine("Среднее арифметическое каждого столбца: ");

    for (int j = 0, k = 0, sum = 0; j < columns; j++, k++, sum = 0)
    {
        for (int i = 0; i < rows; i++)
        {
            sum = sum + Array[i, j];
        }
        // Console.Write($"{sum} \t");
        average[k] = (decimal)sum/rows;
        Console.Write($"{Math.Round(average[k], 1)} \t");
        
    }
}
Task_52();
