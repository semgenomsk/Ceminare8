// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int rows, int cols, int leftRange = 0, int rightRange = 10)
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

int[,] GetTMatrix(int[,]matrix) //перевернутая матрица
{
    int[,] newmatrix = new int[matrix.GetLength(1),matrix.GetLength(0)];
    for (int i=0;i<matrix.GetLength(1);i++)
    {
        for(int j=0;j<matrix.GetLength(0);j++)
        {
            newmatrix[i,j]=matrix[j,i];
        }
    }
    return newmatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int m = ReadNumber("Введите количество строк: ");
int n = ReadNumber("Введите количество столбцов: ");
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr);
int[,]res=GetTMatrix(matr);
Console.WriteLine();
PrintMatrix(res);