void Task41() 
{
Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
Console.WriteLine("Сколько чисел вы хотите ввести?");
int input = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine($"Количество введенных положительных чисел: {CountPositiveNumbers (input)}");
}
int CountPositiveNumbers (int input)
{
int count = 0;
for (int i = 0; i < input; i++)
    {
        Console.WriteLine("Введите целое положительное или отрицательное число");
        int num = Convert.ToInt32 (Console.ReadLine ());
        if (num > 0) { count++; }
    }
return count;
}
Task41();

void Task43() 
{
Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
Console.WriteLine("Введите значение b1");
double b1 = Convert.ToDouble (Console.ReadLine ());
Console.WriteLine("Введите значение k1");
double k1 = Convert.ToDouble (Console.ReadLine ());
Console.WriteLine("Введите значение b2");
double b2 = Convert.ToDouble (Console.ReadLine ());
Console.WriteLine("Введите значение k2");
double k2 = Convert.ToInt32(Console.ReadLine());
double x = FindIntersectionForX (b1, k1, b2, k2);
double y = FindIntersectionForY (b1, k1, x);
Console.WriteLine($"Координаты пересечения двух прямых: ({x}, {y})");
}
Task43();
double FindIntersectionForX (double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}
double FindIntersectionForY (double b1, double k1, double x)
{
    double y = k1 * x + b1;
    return y;
}

