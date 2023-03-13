//Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int[,] matrix1 = CreateMatrixRndInt(2, 3, 0, 10);
Console.WriteLine($"Первая матрица:");
PrintMatrix(matrix1);
int[,] matrix2 = CreateMatrixRndInt(2, 3, 0, 10);
Console.WriteLine($"Вторая матрица:");
PrintMatrix(matrix2);

if (matrix1.GetLength(0) != matrix2.GetLength(1))
{
    Console.WriteLine("Такие матирицы перемножать нельзя!");
    return;
}
int[,] matrixRes = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

// методы
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}

void MultiplyMatrix(int[,] matrix1, int[,] matrix2, int[,] matrixRes)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            matrixRes[i, j] = sum;
        }
    }
}

MultiplyMatrix(matrix1, matrix2, matrixRes);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintMatrix(matrixRes);
