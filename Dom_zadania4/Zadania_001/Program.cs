// Задача 1
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// A в степене B

// Для того, чтобы возвести в степень, нужно вызвать метод Pow, который находится в статическом классе, поэтому необходимо:
// Math.Pow(x, stepen);
// Обратите внимание, что метод принимает значения типа double, если мы объявим тип int, то ошибки не будет:
// int x = 5;
// int stepen = 4;
// Console.WriteLine("5^4 = " + Math.Pow(x, stepen));
// Если вам нужно получить целое число степени, то можете сделать так:
// int i = Convert.ToInt32(Math.Pow(5, 3));
// Если мы напишем:
// int i = Math.Pow(5, 3);
// То будет ошибка, поэтому нужно конвертация в целое число.

// int DlinMass = 10;
// int[] a = new int[DlinMass];
// Console.Write("Массив: ");
// for (int i = 0; i < a.Length; i++)
// {
//     Console.Write("{0} ", i + 1);
// }
// Console.WriteLine();


int x = 5;
int stepen = 4;
Console.WriteLine("5^4 = " + Math.Pow(x, stepen));

int i = Convert.ToInt32(Math.Pow(x, stepen));
Console.WriteLine(i);

