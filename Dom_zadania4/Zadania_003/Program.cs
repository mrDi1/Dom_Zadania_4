// Задача 3
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


// - создать массив
int[] Array(int count)
{
    int[] res = new int[count];
    return res;
}

// - ввод данных рандом
void RandomArray(int[] array, int min, int max)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}

// - вывод на консоль
string ConvertArray(int[] array)
{
    int len = array.Length;
    string result = string.Empty;
    for (int i = 0; i < len; i++)
    {
        result = result + $"{array[i]} ";
    }
    return result;
}


// - Основной код

int[] inArr = Array(8);                                              // - создаем массив состоящи из 10 элиментов
RandomArray(inArr, 0, 100);                                          // - ввод данных в рандом
string outStr = ConvertArray(inArr);                                 // - выводим массива (дано)
Console.WriteLine("Массив из 8 элементов: " + outStr);               // - выводим массива (дано)

// Честно. Все взял с задачи по Инверсии, которую вы написали на уроке. Извините Мне очень стыдно (Я банан) (((