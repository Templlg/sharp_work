{
/*

Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
// Начало задачи 1
// Инициализация переменных
/*
int max = 0, min = 0;
bool val_eqval = false;

Console.Write("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

//Проверка чисел
if (num1 > num2) 
{
    max = num1;
    min = num2;
} 
else if (num1 == num2)
   val_eqval = true;
   //Console.Write("Введенные числа равны");
else    
{
    max = num2;
    min = num1; 
}  
//Вывод сообщений 
if(val_eqval)
    Console.Write("Введенные числа равны");
else    
    Console.Write($"Максимальное число: {max}, Минимальное число: {min}");
//Конец задачи
}
*/
}

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22    
*/
/*__________________________________________________________________________
//Инициализация переменных
int max = 0;

//Ввод переменных пользователем
Console.Write("Введите число 1 - ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2 - ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3 - ");
int num3 = Convert.ToInt32(Console.ReadLine());

max = num1;

if (num2 > max) 
    max = num2;
if (num3 > max) 
    max = num3;  

Console.Write($"Максимальное число: {max}");     
_____________________________________________________________________________________________________________
*/

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/
//Ввод переменных
// Console.Write("Введите число для проверки: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 2 == 0) Console.Write("да");
// else
//     Console.Write("нет");

/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

//Ввод переменных
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int index = 1;
while (index <= N)
{
    if (index % 2 == 0)
    {
        Console.Write(index + " ");
    }
    index++;
}