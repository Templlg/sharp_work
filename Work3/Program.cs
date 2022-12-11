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


/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

int num = 12821;

// количесство цифр
int cout_num = FindCountNum(num);


double num_first = 0;
int num_end = num;
int current = 1;
int m = 1;
bool pal = true;
double m1 = 10000; //Math.Pow(10, cout_num-1);
int count = (cout_num - 1) / 2;
Console.WriteLine($"Степень - {m1}");
//Console.WriteLine(Convert.ToInt32(num_first / m1 % 10));

//m1 = m1 / 10;
//Console.WriteLine(Convert.ToInt32(num_first / m1 % 10));

while (current <= count)
{    
    //num_first = Math.Round(num / m1);
    //Console.WriteLine(num_first); //Math.Truncate
    num_first = Convert.ToInt32(num / m1 % 10);
    Console.WriteLine("1 - " + num_first); 
    num_first = Convert.ToInt32(num / m1 % 10);  //Обход числа с сначала
    m1 = m1 / 10;  

    num_end = Convert.ToInt32( num / m % 10); // Обход числа с конца
    m = m * 10; 
    Console.WriteLine($"Первая цифра - {num_first}, Вторая цифра - {num_end} ");
    if (num_first != num_end)
    {  
        pal = false;
       // Console.WriteLine($"Первая цифра - {num_first}, Вторая цифра - {num_end} ");
        break;
    }    
    current++;
}
//Console.WriteLine(pal);

