/*
int work1(int num)
{
    return num / 10 % 10;
}
*/

/*
int num;

string work2(int num)
{
    if (num > -100 && num < 100) return "Треьй цифры нет";
    
    int result = num % 1000 / 100;

    return $"Третья цифра {result} числа {num}";
}
*/

/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
// Console.Write("Введите трехзначное число - ");
// int num = Convert.ToInt32(Console.ReadLine());
//Console.Write(work1(num));


/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
// Console.Write("Введите число - ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write(work2(num));

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

bool work3(int num)
{
    if (num > 5)
        return true;
    else
        return false;       
}

Console.Write("Введите номер день недели - ");
int num = Convert.ToInt32(Console.ReadLine());
bool is_weekend = work3(num);
if (is_weekend)
    Console.Write($"Это выходной. Отдыхаем");
else
    Console.Write($"Это будни. Нужно идти на работу");   

