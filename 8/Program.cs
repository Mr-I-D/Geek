Console.Clear();

// int m = 3; // Размерность m (строки)
// int n = 4; // Размерность n (столбцы)
// int[,] array = new int[m, n];

// // Метод для заполнения массива случайными числами
// void FillArray(int[,] array)
// {
//     Random random = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = random.Next(0, 10);
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// // Метод для обмена местами первой и последней строк
// int[,] SwapFirstAndLastRow(int[,] array)
// {
//     int[,] newMatrix = new int[m, n]; // Создаем новую матрицу такой же размерности

//     // Копируем последнюю строку в первую
//     for (int j = 0; j < n; j++)
//     {
//         newMatrix[0, j] = array[m - 1, j];
//     }

//     // Копируем первую строку в последнюю
//     for (int j = 0; j < n; j++)
//     {
//         newMatrix[m - 1, j] = array[0, j];
//     }

//     // Копируем оставшиеся строки без изменений
//     for (int i = 1; i < m - 1; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             newMatrix[i, j] = array[i, j];
//         }
//     }

//     return newMatrix;
// }

// FillArray(array);
// Console.WriteLine();

// array = SwapFirstAndLastRow(array);

// // Выводим результат обмена строк
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
// }



// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// int m = 3; // Количество строк
// int n = 4; // Количество столбцов
// int[,] array = new int[m, n];

// // Метод для заполнения массива случайными числами
// void FillArray(int[,] array)
// {
//     Random random = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = random.Next(0, 10);
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// // Метод для замены строк на столбцы
// int[,] SwapRowsAndColumns(int[,] array)
// {
//     // Проверяем возможность замены строк на столбцы
//     if (array.GetLength(0) != array.GetLength(1))
//     {
//         Console.WriteLine("Невозможно заменить строки на столбцы, так как количество строк и столбцов различно.");
//         return null;
//     }

//     int[,] transposedArray = new int[array.GetLength(1), array.GetLength(0)];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             transposedArray[j, i] = array[i, j];
//         }
//     }

//     return transposedArray;
// }

// FillArray(array);
// Console.WriteLine();

// int[,] resultArray = SwapRowsAndColumns(array);

// // Если замена прошла успешно, выводим результат
// if (resultArray != null)
// {
//     for (int i = 0; i < resultArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < resultArray.GetLength(1); j++)
//         {
//             Console.Write(resultArray[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }


// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void SortRowsDescending(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        // Применяем сортировку пузырьком к каждой строке массива
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < array.GetLength(1) - j - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    // Обмен элементов, чтобы упорядочить по убыванию
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
    }
}

int m = 3; // Количество строк
int n = 4; // Количество столбцов
int[,] array = new int[m, n];

// Заполняем массив случайными числами
Random random = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = random.Next(0, 100); // Диапазон случайных чисел: от 0 до 99
    }
}

Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine();

SortRowsDescending(array);

Console.WriteLine("Массив после упорядочивания элементов каждой строки по убыванию:");
PrintArray(array);
