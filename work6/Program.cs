int CountPositiveNum(int m)
{
    int num = 0;
    int count = 0;
    for (int i=0; i < m; i++)
    {
        Console.Write($"Число {i+1} - ");
        num = Convert.ToInt32(Console.ReadLine());
        if (num > 0)
        {
            count++;
        }
    }

    return count;
}


//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3
/*
Console.Write("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());

int count = CreateRandomArray(m);

Console.Write($"Количество числе больше нуля {count}");
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Первое уравнение, число b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Первое уравнение, число k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Второе уравнение, число b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Второе уравнение, число k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = (b2 * k1 - b1 * k2) / (k1 - k2);

//Console.WriteLine($"Координата y: {y}");
//Console.WriteLine($"Координата x: {x}");

Console.WriteLine($"Координаты общей точки: {x} {y}");