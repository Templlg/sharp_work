//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16
/*
double exponent(int num1, int num2)
{    
    //return Math.Pow(num1, num2);
    int result = num1;
    for (int current = 1; current < num2; current++)
    {
        result = result * num1;
        //Console.Write(current);
    }
    return result;
}

Console.Write("Введите число А - ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень - ");
int num2 = Convert.ToInt32(Console.ReadLine());

double num3 = exponent(num1, num2);
Console.WriteLine($"Степень {num2} числа {num1} = {num3}");
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

//// Функция определяет количество знаков в числе
// параметр - целое число 
// возвращает количество цифр в числе. в формет int

/*
int FindCountNum(int num)
{
    int cout_num = 0;
    int m = 1;
    bool flag = true;
    while(flag)
    {
        m = m*10;
        if (num / m > 0)
        {
            cout_num++;
        }
        else 
        {
            cout_num++;      
            flag = false; 
        }
    
    }
    return cout_num;
}

Console.Write("Введите число  - ");
int num1 = Convert.ToInt32(Console.ReadLine());

int count_num = FindCountNum(num1);
double m = 1;
int sum = 0;
for(int current = 1; current <= count_num; current++)
{
    sum = sum + Convert.ToInt32(num1 / m % 10 );
    m = m * 10;
    //sum = sum

}

Console.Write($"Сумма чисел числа {num1} - {sum}");
*/

///-------------------------------------------------------------------------------------------------------
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for (int i =0; i < size; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
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


Console.Write("Размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
//int[] array = new int[size]; 

int[] array = CreateRandomArray(size);

ShowArray(array);



