// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


// Console.Write("Введите длинну массива: ");
// int size = Convert.ToInt32(Console.ReadLine());;
// int[] array = new int[size];
// Random myRandom = new Random();

// Console.WriteLine("Вывод исходного массива ");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = myRandom.Next(100, 900);
//     Console.Write("{0}; ", array[i]);
// }

// Console.WriteLine();
// Console.WriteLine("Отсортированный массив: ");
// Array.Sort(array);
 
// foreach (var i in array)
// {
//     Console.Write("{0}; ", i);
// }

// int countPozitive = 0;
// {
// for (int i = 0; i < array.Length; i++)
// {
// if (array[i] % 2 == 0)
// countPozitive = countPozitive + 1;
// }
// }
// Console.Write($" - Количество чётных чисел в массиве:" + (countPozitive) );

// int countNegativ = 0;
// {
// for (int i = 0; i < array.Length; i++)
// {
// if (array[i] % 2 == 1)
// countNegativ = countNegativ + 1;
// }
// }
// Console.WriteLine($" - Количество нечётных чисел в массиве:" + (countNegativ) );
// Console.WriteLine($"Итого количество чисел массива - " + (countNegativ + countPozitive) );





////////////////////////////////////////////////////////////////


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


// Console.Write("Введите длинну массива: ");
// int size = Convert.ToInt32(Console.ReadLine());;
// int[] array = new int[size];
// Random myRandom = new Random();

// Console.WriteLine("Вывод исходного массива ");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = myRandom.Next(-50, 50);
//     Console.Write("{0}; ", array[i]);
// }


// int countNegativ = 0;
// {
// for (int i = 1; i < array.Length; i=i + 2)
// {
//     countNegativ = countNegativ + array[i];
// }
// }
// Console.WriteLine($" - Сумма элементов стоящих на нечётных позициях:" + (countNegativ) );



//////////////////////////////////////////////////////////////////////////////////


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Диапазон [-10, 10]. Обратите внимание на вещественных чисел
// Для примера возьмём диапазон побольше. [3 7 22 2 78] -> 76

Console.Write("Введите длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());;
double[] array = new double[size];
Random myRandom = new Random();


Console.WriteLine("Вывод исходного массива ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = myRandom.NextDouble() * 100;
Console.Write("; " + Math.Round(array[i],2));
 }

Console.WriteLine();
Console.WriteLine("Отсортированный массив: ");
Array.Sort(array);
 
foreach (var i in array)
{
    Console.Write("; " + Math.Round(i,2));
    
}

double maxNumber = array[array.Length - 1];
double minNumber = array[0];
double total = maxNumber - minNumber;
Console.WriteLine();
Console.WriteLine("Разница между минимальным и максимальным значением массива = " + Math.Round(total,2));




