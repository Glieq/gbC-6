// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int Promt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int lengthOfArr = Promt("Введите кол-во чисел: ");

int[] generateArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = Promt("Введите число: ");
    }
    return array;
}

int CheckingForAPositiveNumber(int[] mas)
{
    int count = 0;
    for (int i = 0; i < lengthOfArr; i++)
    {
        if (mas[i] > 0)
        {
            count++;
        }
    }
    return count;
}

System.Console.WriteLine($"Вы ввели {CheckingForAPositiveNumber(generateArray(lengthOfArr))} чисел больше 0");
