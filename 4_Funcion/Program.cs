
// // Метод для ввода числа с консоли
// static int Parse(string text)
// {
//     Console.WriteLine(text);
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// // Метод для вычисления количества цифр в числе
// static int CountDigits(int num)
// {
//     int count = 1;
//     while (num > 9)
//     {
//         num /= 10;
//         count++;
//     }
//     return count;
// }

// // Метод для вычисления факториала числа N
// static int CalculateFactorial(int num)
// {
//     int factorial = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         factorial *= i;
//     }
//     return factorial;
// }

// // Метод для генерации массива из 8 элементов, заполненного нулями и единицами
// static void GenerateRandomArray()
// {
//     int[] array = new int[8];
//     Random random = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(2);
//         Console.Write($"{array[i]} ");
//     }

//     Console.WriteLine();

//     foreach (int item in array)
//     {
//         Console.Write($"{item} ");
//     }

//     Console.WriteLine();

//     Console.Write(string.Join(", ", array));
// }

// // Метод для возведения числа A в степень B
// static int Power(int num1, int num2)
// {
//     int result = 1;
//     for (int i = 0; i < num2; i++)
//     {
//         result *= num1;
//     }
//     return result;
// }

// // Метод для подсчета суммы цифр в числе
// static int SumOfDigits(int num)
// {
//     int sum = 0;
//     while (num > 0)
//     {
//         sum += num % 10;
//         num /= 10;
//     }
//     return sum;
// }

// static void Main()
// {
//     Console.Clear();

//     // Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//     int number = Parse("Введите число");
//     int result = CountDigits(number);
//     Console.WriteLine(result);

//     // Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//     number = Parse("Введите число");
//     result = CalculateFactorial(number);
//     Console.WriteLine(result);

//     // Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//     GenerateRandomArray();

//     // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//     int num1 = Parse("Введите число");
//     int num2 = Parse("Введите степень");
//     result = Power(num1, num2);
//     Console.WriteLine(result);

//     // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//     Console.WriteLine("Введите число:");
//     number = Convert.ToInt32(Console.ReadLine());
//     result = SumOfDigits(number);
//     Console.WriteLine(result);
// }
