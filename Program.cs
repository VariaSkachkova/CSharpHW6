void Task41() 
{
Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
Console.WriteLine("Сколько чисел вы хотите ввести?");
int input = Convert.ToInt32 (Console.ReadLine ());
int count = 0;
for (int i = 0; i < input; i++)
    {
        Console.WriteLine("Введите целое положительное или отрицательное число");
        int num = Convert.ToInt32 (Console.ReadLine ());
        if (num > 0) { count++; }
    }
Console.WriteLine($"Количество введенных положительных чисел: {count}");
}
//Task41();

void Task43() 
{
Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
Console.WriteLine("Введите значение b1");
int b1 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine("Введите значение k1");
int k1 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine("Введите значение b2");
int b2 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine("Введите значение k2");
int k2 = Convert.ToInt32 (Console.ReadLine ());
int x = (b2 - b1)/(k1 - k2);
int y = k1*((b2 - b1)/(k1 - k2)) + b1;
Console.WriteLine($"Координаты пересечения двух прямых: ({x}, {y})");
}
Task43();
