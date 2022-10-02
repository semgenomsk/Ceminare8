// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается 
// элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9

int ReadNumber(string message) // Ввод числа из консоли.
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int rows, int cols, int leftRange = 0, int rightRange = 9) // Наполнение массива случайными числами.
{
    int[,] matrix = new int[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) // Вывод массива в терминал.
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void CountElementsOfMatrix(int[,] matrix) // Подсчет количества каждого элемента матрицы
{
    int count = 0;
    for (int k = 0; k < 10; k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == k) count++;
            }
        }
        if (count != 0)
        {
            Console.WriteLine($"Элемент {k} встречается {count} раз");
            count = 0;
        }
    }
}

int m = ReadNumber("Введите количество строк матрицы: ");
int n = ReadNumber("Введите количество столбцов матрицы: ");
int[,] matr = GetMatrix(m, n);
Console.WriteLine("Исходная матрица:");
PrintMatrix(matr);
Console.WriteLine();
CountElementsOfMatrix(matr);