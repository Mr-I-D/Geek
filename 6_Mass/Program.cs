Console.Clear();
// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// Console.WriteLine("Введите три числа для проверки треугольника:");
// Console.Write("Введите первое число: ");
// double side1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите второе число: ");
// double side2 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите третье число: ");
// double side3 = Convert.ToDouble(Console.ReadLine());

// // Проверяем, может ли существовать треугольник
// if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
// {
//     Console.WriteLine("Треугольник с такими сторонами может существовать.");
// }
// else
// {
//     Console.WriteLine("Треугольник с такими сторонами не может существовать.");
// }


// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

// Исходный массив
// int[] array = { 1, 2, 3, 4, 5 };

// // Создание массива-копии
// int[] copyArray = new int[array.Length];
// Array.Copy(array, copyArray, array.Length);

// // Вывод исходного и скопированного массивов
// Console.WriteLine("Исходный массив: " + String.Join(", ", array));
// Console.WriteLine("Скопированный массив: " + String.Join(", ", copyArray));


// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.WriteLine("Введите количество чисел:");
// int M = Convert.ToInt32(Console.ReadLine());

// int count = 0;

// for (int i = 0; i < M; i++)
// {
//     Console.WriteLine($"Введите число №{i + 1}:");
//     int number = Convert.ToInt32(Console.ReadLine());

//     if (number > 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine($"Количество чисел больше нуля: {count}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Введите значения b1, k1, b2, k2 через пробел:");
string input = Console.ReadLine();

// Разделение введенной строки на числа
string[] values = input.Split(' ');

if (values.Length == 4)
{
    // Парсинг значений коэффициентов
    if (double.TryParse(values[0], out double b1) &&
        double.TryParse(values[1], out double k1) &&
        double.TryParse(values[2], out double b2) &&
        double.TryParse(values[3], out double k2))
    {
        // Расчет точки пересечения прямых
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;

        Console.WriteLine($"Точка пересечения прямых: ({x}; {y})");
    }
    else
    {
        Console.WriteLine("Ошибка ввода. Проверьте введенные значения.");
    }
}
else
{
    Console.WriteLine("Некорректный ввод. Введите 4 числа через пробел.");
}
