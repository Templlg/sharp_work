int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for (int i=0; i < size; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}

int[] CreateRandomArray1(int size, int min, int max)
{
    max++;
    int[] array = new int[size];
    for (int i=0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

double[] CreateRandomArrayDouble(int size, int min, int max)
{
    max++;
    double[] array = new double[size];
    for (int i=0; i < size; i++)
    {
        array[i] = Math.Round( new Random().Next(min, max) + new Random().NextDouble(), 3);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{i + 1} element is {array[i]}");        
    }
}

void ShowArrayDouble(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{i + 1} element is {array[i]}");        
    }
}

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2
/*
Console.Write("Размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int num = 0;
int count = 0;

int[] array = CreateRandomArray(size);


int count_even = 0;

for (int i = 0; i < size; i++)
{
    num = array[i];        
    if (num % 2 == 0) count_even++;      
}
Console.WriteLine($"Количество четных чисел в массиве - {count_even}");
*/


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0
/*
Console.Write("Размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Минимальное число массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Максимальное число массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray1(size, min, max);

ShowArray(array);

int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    if ((i+1) % 2 != 0)
    { 
        Console.WriteLine($"Место позиции {i}, Число - {array[i+1]}");
        sum = sum + array[i];
    }
}
Console.WriteLine($"сумму элементов, стоящих на нечётных позициях - {sum}");
*/


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76


Console.Write("Размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Минимальное число массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Максимальное число массива: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] array = CreateRandomArrayDouble(size, min, max);

ShowArrayDouble(array);
double max_d = array[0];
double min_d = array[0];

for (int i = 0; i < array.Length; i++)
{   
    //Определение макс числа
    if (max_d < array[i]) max_d = array[i];

    //определение мин числа
    if (min_d > array[i]) min_d = array[i];     
}

Console.Write($"Разница между максимальным и минимальным элементами массива {max_d - min_d}");




