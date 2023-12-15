Console.Clear();

// // // Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].

// // int[] array = new int[12]; // Создание массива из 12 элементов

// // int sumPositive = 0; // Инициализация переменной для суммы положительных чисел
// // int sumNegative = 0; // Инициализация переменной для суммы отрицательных чисел

// // FillArray(array); // Заполнение массива случайными числами

// // foreach (int number in array) // Проход по всем элементам массива
// // {
// //     if (number > 0) // Проверка, является ли число положительным
// //     {
// //         sumPositive = sumPositive + number; // Если положительное, добавляем его к сумме положительных чисел
// //     }
// //     else
// //     {
// //         sumNegative += number; // Если отрицательное, добавляем его к сумме отрицательных чисел
// //     }
// // }

// // Console.WriteLine($"Сумма положительных = {sumPositive}, сумма отрицательных = {sumNegative}"); // Вывод сумм положительных и отрицательных чисел

// // void FillArray(int[] array) // Метод для заполнения массива случайными числами от -9 до 9
// // {
// //     for (int i = 0; i < array.Length; i++) // Проход по всем элементам массива
// //     {
// //         array[i] = new Random().Next(-9, 10); // Генерация случайного числа и его добавление в массив
// //     }
// //     Console.WriteLine(String.Join(" ", array)); // Вывод массива на экран (для демонстрации)
// // }



// // Задача 32: Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.
// // [-4, -8, 8, 2] -> [4, 8, -8, -2]

// // int[] array = new int[10];

// // void FillArray(int[] array)
// // {
// //     for (int i = 0; i < array.Length; i++)
// //     {
// //         array[i] = new Random().Next(-9, 10);
// //     }
// //     Console.WriteLine(String.Join(" ", array));
// // }
// // FillArray(array);

// // for (int i = 0; i < array.Length; i++)
// // {
// //     array[i] *= -1;
// // }
// // Console.WriteLine(String.Join(" ", array));


// // Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// // 4; массив [6, 7, 19, 345, 3] -> нет
// // -3; массив [6, 7, 19, 345, -3] -> да

// int[] array = new int[10];
// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9, 10);
//     }
//     Console.WriteLine(String.Join(" ", array));
// }

// bool Examin(int[] array, int num1)
// {
//     bool isFound = false;

//     foreach (int number in array)
//     {
//         if (number == num1)
//         {
//             isFound = true;
//             break;
//         }
//     }

//     if (isFound)
//     {
//         Console.WriteLine("Да");
//     }
//     else
//     {
//         Console.WriteLine("Нет");
//     }

//     return isFound;
// }

// FillArray(array); // Заполняем массив случайными числами

// // После заполнения массива вызываем функцию Examin для поиска числа в массиве
// Examin(array, num1);

// Задача 35: Задайте одномерный массив из 123 случайных чисел. 4
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] array = new int[123];
// int count = 0;

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 124);
//     }
//     Console.WriteLine(String.Join(" ", array));
// }
// FillArray(array);

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 9 && array[i] < 100)
//     {
//         count++;
//     }
// }
// Console.WriteLine(count);


// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


// int[] array = new int[Convert.ToInt32(Console.ReadLine())];
// int[] secondArray = new int[array.Length / 2 + array.Length % 2];

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 10);
//     }
//     Console.WriteLine(String.Join(" ", array));
// }

// void SecondFillArray(int[] secondArray, int[] array, int length)
// {
//     for (int i = 0; i < secondArray.Length; i++)
//     {
//         secondArray[i] = array[i] * array[length - i - 1];
//     }
//     Console.WriteLine(String.Join(" ", secondArray));
// }

// FillArray(array);
// SecondFillArray(secondArray, array, array.Length);


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

//     // Получаем размер массива от пользователя
//     int size = Convert.ToInt32(Console.ReadLine());
//     int[] array = new int[size]; // Создаем массив заданного размера

//     FillArray(array); // Заполняем массив случайными трехзначными числами
//     int count = Sum(array); // Получаем количество четных чисел в массиве
//     Console.WriteLine(count); // Выводим результат на экран

// void FillArray(int[] array)
// {
//     Random rand = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rand.Next(100, 1000); // Заполняем массив случайными трехзначными числами
//     }
//     Console.WriteLine(String.Join(" ", array)); // Выводим заполненный массив на экран
// }

// static int Sum(int[] array)
// {
//     int count = 0; // Переменная для хранения количества четных чисел

//     // Подсчитываем количество четных чисел в массиве
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) // Если число четное
//         {
//             count++; // Увеличиваем счетчик четных чисел
//         }
//     }
//     return count; // Возвращаем количество четных чисел
// }

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];    

// void FillArray(int[] array)
// {
//     Random rand = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rand.Next(0, 10);
//     }
//     Console.WriteLine(String.Join(" ", array));
// }

// int Summ(int[] array)
// {
//     int sum = 0;
//     for (int i = 1; i < array.Length; i += 2)
//     {
//         sum += array[i];
//     }
//     return sum;
// }


// FillArray(array);
// Console.WriteLine(Summ(array));

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// int size = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[size];

// void FillArray(double[] array)
// {
//     Random rand = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Math.Round(rand.NextDouble() * 100, 2);
//     }
//     Console.WriteLine(String.Join(" ", array));
// }

// double min = double.MaxValue; // Устанавливаем начальное значение min как максимально возможное число
// double max = double.MinValue; // Устанавливаем начальное значение max как минимально возможное число

// FillArray(array);

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > max)
//     {
//         max = array[i]; // Обновляем значение max
//     }
//     if (array[i] < min)
//     {
//         min = array[i]; // Обновляем значение min
//     }
// }

// double difference = max - min; // Находим разницу между max и min
// Console.WriteLine($"{max} - {min} => {difference}");
