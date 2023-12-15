
Console.Clear();

// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
int m = 3; // Размерность m (строки)
int n = 4; // Размерность n (столбцы)
int[,] array = new int[3, 4];
Console.WriteLine("FillArray");
void FillArray(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

FillArray(array);


// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
Console.WriteLine("CreateFormulaArray");
void CreateFormulaArray(int[,] array, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = i + j;
        }
    }

    // Вывод массива на экран
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine(); // Переход на новую строку для новой строки матрицы
    }
}

// Для использования метода:
int[,] formulaArray = new int[m, n]; // Создание нового массива

CreateFormulaArray(formulaArray, m, n);


// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
Console.WriteLine("Rooting");
void Rooting(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0) // Проверяем, что оба индекса нечетные
            {
                array[i, j] *= array[i, j]; // Заменяем элемент на его квадрат
            }
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Rooting(array);


// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Console.WriteLine("Sum");
int Sum(int[,] array)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                count += array[i, j];
            }
        }
    }
    return count;
}

Console.WriteLine(Sum(array));
