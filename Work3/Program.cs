/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
4212 -> нет
12821 -> да
23432 -> да
*/

//// Функция определяет количество знаков в числе
// параметр - целое число 
// возвращает количество цифр в числе. в формет int
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

// функция определеяет число паллиндром или нет
// на вход два параметра само число и количество цифр в числе.
// возвращает переменную bool
bool is_palindrome(int num, int cout_num)
{
    //счетчики для цикла
    int count = 0; //cout_num / 2; // сколько раз нужно считать
    int current = 1;

    if (cout_num % 2 == 0)
        {
        double m1 = Math.Pow(10, cout_num);   // множитель для обхода числа с первой цифры если четное
        count = cout_num / 2;
        }
    else
        {
        count = (cout_num - 1) / 2;
        double m1 = Math.Pow(10, cout_num-1); // множитель для обхода числа с первой цифры если нечетное
        }      

    //множители для вычисления разряда с конца числа
    int m = 1;
    bool palindrome = true;

    //Инициализация переменных для сравнения разрядов 
    double num_first = 0;
    int num_end = num; 

    while (current <= count)
    {       
        num_first = num / m1;
        num_first = Math.Round(num_first); // не работает
                
        num_first = Math.Round(num / m1 % 10);  //Обход числа с сначала  не работает
        m1 = m1 / 10;     

        num_end = Convert.ToInt32( num / m % 10); // Обход числа с конца
        m = m * 10; 

        if (num_first != num_end)
        {  
            palindrome = false;       
            break;
        }    
        current++;
    } 
    return palindrome;
}

Consle.Write("Введите число для проверки палиндром - ");
int num = Convert.ToInt32(Console.ReadLine());
//int num = 12821;

// количесство цифр в числе
int cout_digit = FindCountNum(num);
// Определение палидрома числа
bool palindrome = is_palindrome(num, cout_digit);

Consle.WriteLine($"Это число Палиндром {palindrome}");




//Console.WriteLine(pal);


//Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double FindDistance(double xA, double yA, double zA, 
                    double xB, double yB, double zB, 
                    double xC, double yC, double zC)
{
    double distance = Math.Sqrt(Math.Pow(xA - xB - xC, 2)) 
                    + Math.Sqrt(Math.Pow(yA - yB - yC, 2)) 
                    + Math.Sqrt(Math.Pow(xC - yC - zC, 2));

                    return distance;
}

Console.Write("Введите X точки 1 - ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y точки 1 - ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Z точки 1 - ");
double xC = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите X точки 2 - ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y точки 2 - ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Z точки 2 - ");
double yC = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите X точки 3 - ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y точки 3 - ");
double zB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Z точки 3 - ");
double zC = Convert.ToDouble(Console.ReadLine());

double distance = FindDistance(xA, xB, xC, yA, yB, yC, zA, zB, zC);
Console.WriteLine($"Дистанция между точками - {distance}")
*/

//Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
/*
Console.Write("По какому числу будем расчитывать таблицу кубов? ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 1;
while (current <= num)
{
    Console.Write(Math.Pow(current, 3)+" ");
    current++;
}
*/