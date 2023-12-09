Console.Clear();

// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

char[,] CreateFilledCharMatrix(int rowes, int columnes, string str)  // Метод принимает количество строк, 
// количество столбцов, строку и возвращает двумерный массив заполненый 
// символами из строки в случайном порядке.
{
    char[,] charMatrix = new char[rowes, columnes];
    Random rand = new Random();
    for (int i = 0; i < charMatrix.GetLength(0); i++)

        for (int j = 0; j < charMatrix.GetLength(1); j++)
        {
            charMatrix[i, j] = str[rand.Next(0, str.Length)];
        }
    return charMatrix;
}

void PrintCharMatrix(char[,] charMatrix) // Метод принимает двумерный массив символов 
//и выводит его на экран в виде матрицы.
{
    for (int i = 0; i < charMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < charMatrix.GetLength(1); j++)
        {
            Console.Write($"{charMatrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void PrintCharMatrixToString(char[,] charMatrix) // Метод принимает двумерный массив символов 
//и выводит его на экран в виде строки.
{
    for (int i = 0; i < charMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < charMatrix.GetLength(1); j++)
        {
            Console.Write($"{charMatrix[i, j]}\t");
        }
    }
}

string GetStringFromCharArray(char[,] simbolMatrix) // Метод принимает двумерный массив символов и
// возвращает строку из этих символов.
{
    string str = String.Empty;
    { 
        for (int m = 0; m < simbolMatrix.GetLength(0); m++)
        {
            for (int n = 0; n < simbolMatrix.GetLength(1); n++)
            {
                str += simbolMatrix[m, n];
            }
        }
    }
    return str;
}

char[,] simbolMatrix = CreateFilledCharMatrix(4, 5, "BorisRazor");
PrintCharMatrix(simbolMatrix);
Console.WriteLine();
Console.WriteLine(GetStringFromCharArray(simbolMatrix));
// PrintCharMatrixToString(simbolMatrix);


