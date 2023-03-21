// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

int Promt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int b1 = Promt("Введите b1: ");
int k1 = Promt("Введите k1: ");
int b2 = Promt("Введите b2: ");
int k2 = Promt("Введите k2: ");

double x = -100;
double y1 = 0;
double y2 = 0;
while (x <= 100)
{
    y1 = k1 * x + b1;
    y2 = k2 * x + b2;
    if (y1 == y2)
    {
        System.Console.WriteLine($"Прямые пересекаются в точке {y1};{x}");
        return;
    }
    y1 = 0;
    y1 = 0;
    x = x + 0.5;
}

