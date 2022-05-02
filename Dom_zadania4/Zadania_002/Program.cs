// Задача 2
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


// - создать массив
// - ввод данных
// - складование элементов массива
// - вывод на консоль


//_______________________________________________Написал для подсматривания__________________________________________________________________________________________

// - создать массив
int[] Array(int count)
{
    int[] res = new int[count];
    return res;
}

// - ввод данных
void ArrayConsole(int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write($"array[{i}]: ");
        array[i] = int.Parse(Console.ReadLine());
    }
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

// - инверсия
int[] Inverse(int[] array)
{
    int len = array.Length;
    int[] result = new int[len];
    for (int i = 0; i < len; i++)
    {
        result[i] = array[i] + array[i];
    }
    return result;
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

// int[] inArr = Array(5);                           // - создаем массив состоящи из 10 элиментов
// // ArrayConsole(inArr);                           // - ввод данных в ручную
// RandomArray(inArr, 0, 5);                         // - ввод данных в рандом
// string outStr = ConvertArray(inArr);              // - выводим массива (дано)
// Console.WriteLine(outStr);                        // - выводим массива (дано)
// int[] outArr = Inverse(inArr);                    // - создаем новый массив и заполняем его отрицательными цислами
// outStr = ConvertArray(outArr);                    // - выводим массива (итог)
// Console.WriteLine(outStr);                        // - выводим массива (итог)


//_______________________________________________Написал без метода______________________________________________________________________________________________________

int summ = 0;

Console.WriteLine("Пожалуйста, введите размер массива");
int size = int.Parse(Console.ReadLine());
int[] mass = new int[size];

Console.WriteLine("Введите число, равное вашему массивному размеруe");
string s = Console.ReadLine();

for (int i = 0; i < s.Length; i++)
{
    mass[i] = int.Parse(s[i].ToString());
}

for (int i = 0; i < mass.Length; i++)
{
    summ = mass[i] + summ;
}

Console.WriteLine("сумму цифр в числе = " + summ);


// //_________________________________________________Пытаюсь сделать задачу через методы((_________________Ничего не получается((________________________________________________________________

// // - создаем массив состоящи из __ элиментов
// int[] ElementArray(int count)
// {
//     Console.WriteLine("Пожалуйста, введите размер массива");
//     int size = int.Parse(Console.ReadLine());
//     int[] mass = new int[size];
// }

// // - ввод данных в ручную
// void ConsoleArray(int[] array)
// {
//     Console.WriteLine("Введите число, равное вашему массивному размеруe");
//     string s = Console.ReadLine();
// }

// // - расчет суммы
// int[] Summ(int[] array)
// {
//     for (int i = 0; i < s.Length; i++)
//     {
//         mass[i] = int.Parse(s[i].ToString());
//     }

//     for (int i = 0; i < mass.Length; i++)
//     {
//         summ = mass[i] + summ;
//     }
// }

// - Основной код

// int[] massiv = ElementArray();        // - создаем массив состоящи из __ элиментов
// ConsoleArray(massiv);                 // - ввод данных в ручную
// int n = Summ(massiv);                 // - расчет суммы

// Console.WriteLine("сумму цифр в числе = " + n);


