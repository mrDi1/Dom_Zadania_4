// Задача 1
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// A в степене B


// самое простое решение

// int x = 5;
// int stepen = 4;
// Console.WriteLine("5^4 = " + Math.Pow(x, stepen));
// int i = Convert.ToInt32(Math.Pow(x, stepen));
// Console.WriteLine(i);


// цикл

int a = 5;
int b = 4;
int pow = 1;
for (int i = 0; i < b; i++)
{
    pow *= a;                               // умножаем и присваеваем значение
}
Console.WriteLine($"{a} ^ {b} = {pow}");