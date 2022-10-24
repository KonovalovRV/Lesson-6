// Задача 1: Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Разделить ввод данных, от расчета данных (Одна функция вводит данные,
// другая функция подсчитывает количество положительных)
// 0,7,8, -2, -2 -> 2
// 1,-7, 567, 89, 223-> 3

int Prompt(string message)
{
    Console.WriteLine(message);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

int Sizearray()
{
    int length = Prompt("Укажите размер массива   ");
    return length;
}

int len = Sizearray();

int[] Fillcoll(int[] array)
{
    for (int index = 0; index < len; index++)
    {
        array[index] = Prompt("Введите число");
    }
    return array;
}

int[] col = Fillcoll(new int[len]);

void PrintArray(int[] collection)
{
    for (int index = 0; index < col.Length; index++)
    {
        System.Console.Write($"{col[index]}\t");
    }
    System.Console.WriteLine();
}

PrintArray(col);

int QuantityPositivNumbers(int[] coll)
{
    int count = 0;
    for (int i = 0; i < coll.Length; i++)
    {
        if (coll[i] > 0)
        {
            count++;
        }
    }
    return count;
}


Console.WriteLine($"Количество положительных чисел равно {QuantityPositivNumbers(col)}");








