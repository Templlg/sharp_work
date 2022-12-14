
int[,] CreateArrayRandomInt()
{
    //Console.Write("Количество строк - ");
    int rows =  3; //Convert.ToInt32(Console.ReadLine());
    //Console.Write("Количество колонок - ");
    int columns = 4; //Convert.ToInt32(Console.ReadLine());

    //Console.Write("Минимальное число массива - ");
    int minValue = 1; //Convert.ToInt32(Console.ReadLine());
    //Console.Write("Максимальное число массива - ");
    int maxValue = 9; //Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i=0; i < rows; i++)
    {
        for (int j=0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue);            
        }
    }
    return array;
}

int[,] CreateArrayRandomInt2()
{
    //Console.Write("Количество строк - ");
    int rows =  2; //Convert.ToInt32(Console.ReadLine());
    //Console.Write("Количество колонок - ");
    int columns = 2; //Convert.ToInt32(Console.ReadLine());

    //Console.Write("Минимальное число массива - ");
    int minValue = 1; //Convert.ToInt32(Console.ReadLine());
    //Console.Write("Максимальное число массива - ");
    int maxValue = 9; //Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i=0; i < rows; i++)
    {
        for (int j=0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue);            
        }
    }
    return array;
}


void Show2dArrayInt(int[,] array)
{
     for(int i = 0; i < array.GetLength(0);i++)
     {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
            //Console.Write(array[j,] + "\t");
        }
        Console.WriteLine();
     }
     Console.WriteLine();
}

void ShowdArrayInt(int[] array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {        
    Console.Write(array[i] + "\t");
    //Console.Write(array[j,] + "\t");        
    }     
}
/*
int[] CreateRandomArray()
{
   int[] array = new int[4];

   array[0] = 1;
   array[1] = 4;
   array[2] = 7;
   array[3] = 2;
   return array;
}
*/
// Знакомство с языками программирования (семинары)
// Урок 8. Двумерные массивы. Продолжение
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
//int[] array = CreateRandomArray1();
/*
int[,]array = CreateArrayRandomInt();

Show2dArrayInt(array);

for(int i=0; i < array.GetLength(0); i++)
{  
    //int temp = 0;
    for(int j=0; j < array.GetLength(1); j++)
    {  
    int min_position = j;         
    for(int k=j+1; k < array.GetLength(1); k++)
    {        
        if (array[i, k] < array[i, min_position])
        {
            min_position = k;
        }
        int temp = array[i, k];
        array[i, k] = array[i, min_position];
        array[i, min_position] = temp;    
    }         
    } 
       
}

Console.WriteLine();
Show2dArrayInt(array);
*/
// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
int[,] array = CreateArrayRandomInt();


int[] array_sum = new int[array.GetLength(0)];
//Show2dArrayInt(array);

for(int i=0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for(int j=0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];
    }
    Console.WriteLine($"Сумма по строке {i+1} {sum}");
    array_sum[i] = sum;
}

int min = 0;
for(int i=1; i < array_sum.Length; i++)
{
    if (array_sum[min] > array_sum[i])
    {
        min = i;
    }
}
Console.WriteLine($"Минимальная сумма в строке {min+1}");
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] matrix1 = CreateArrayRandomInt2(); 
Show2dArrayInt(matrix1);
int[,] matrix2 = CreateArrayRandomInt2(); 
Show2dArrayInt(matrix2);

int[,] matrix3 = new int[2,2];
matrix3[0,0] = matrix1[0,0] * matrix2[0,0] + matrix1[0,1] * matrix2[1,0];
matrix3[0,1] = matrix1[0,0] * matrix2[0,1] + matrix1[1,0] * matrix2[1,1];
matrix3[1,0] = matrix1[1,0] * matrix2[0,0] + matrix1[1,1] * matrix2[1,0];
matrix3[1,1] = matrix1[0,1] * matrix2[0,1] + matrix1[1,1] * matrix2[1,1];
Show2dArrayInt(matrix3);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07