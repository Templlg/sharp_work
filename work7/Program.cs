double[,] CreateArrayRandomReal()
{
    Console.Write("Количество строк - ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Количество колонок - ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Минимальное число массива - ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Максимальное число массива - ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for (int i=0; i < rows; i++)
    {
        for (int j=0; j < columns; j++)
        {
            array[i,j] = Math.Round( new Random().Next(minValue, maxValue) + new Random().NextDouble(), 3);
        }
    }
    return array;
}

void Show2dArray(double[,] array)
{
     for(int i = 0; i < array.GetLength(0);i++)
     {
        for(int j = 0;j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
     }
     Console.WriteLine();
}

double FindElement(double[,] array, int row, int column)
{
    int CountRows = array.GetLength(0);
    int CountColomns = array.GetLength(1);

    if (row > CountRows | column > CountColomns)
    {
        return -1;
    }
    return array[row, column];
}

/*
Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
double[,] array = CreateArrayRandomReal();
Show2dArray(array);



/*
Задача 50. Напишите программу, 
которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> числа с такими индексами в массиве нет
*/

Console.Write("Номер строки массива - ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Номер колонки массива - ");
int column = Convert.ToInt32(Console.ReadLine());

double value = FindElement(array, row, column);
if (value == -1)
    Console.Write($"В этом массиве такой позиции нету"); 
else  
    Console.Write($"Значение {value}");  
    
/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


