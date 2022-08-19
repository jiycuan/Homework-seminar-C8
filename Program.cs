// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void Zadacha54()
{

    Random rand = new Random();    
    int line = new Random().Next(5,10);
    int column = new Random().Next(5,10);
    int[,] matrix = new int [line, column];

    FillArrayInt(matrix);
    PrintArrayInt(matrix);
    SortArray(matrix);
    Console.WriteLine();
    PrintArrayInt(matrix);
}

void FillArrayInt(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1,10);
        }
    }
}

void PrintArrayInt(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}" + "\t" );
        }
    Console.WriteLine();
    }
}

void SortArray(int[,] matrix)
{   
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           int position = j;
           for (int k = j+1; k < matrix.GetLength(1); k++)
           {
                if (matrix[i, k] > matrix[i, position]) position = k;
           }
           int temp = matrix[i, j];
           matrix[i, j] = matrix[i, position];
           matrix[i, position] = temp;
        }
    }
}

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void Zadacha56()
{
    Random rand = new Random();    
    int line = new Random().Next(3,6);
    int column = new Random().Next(3,6);
    int[,] matrix = new int [line, column];

    FillArrayInt(matrix);
    PrintArrayInt(matrix);
    FindMinSumString(matrix);
    Console.WriteLine();
}

void FindMinSumString(int[,] matrix)
{
    int sum;
    int size = matrix.GetLength(0);
    int[] SumArray = new int[size];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {    
        sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i,j];
        }
        SumArray[i] = sum;
    }
    int min = 0;
    for (int i = 0; i < size; i++)
    {   
        if (SumArray[i] < SumArray[min]) min = i;
    }
    Console.WriteLine("Номер строки с наименьшей суммой элементов (подсчет для казуалов, нулевую строку считаем первой): " + (min+1));
}

// Задача 58. Заполните спирально массив 4 на 4 числами от 1 до 16.

void Zadacha58()
{
    Random rand = new Random();
    int lines = 4;
    int column = lines;
    int[,] matrix = new int [lines, column];
    int iStart = 0;
    int iEnd = 0;
    int jStart = 0;
    int jEnd = 0;

    int k = 1;
    int i = 0;
    int j = 0;

    while (k <= lines*column)
    {   
        matrix[i, j] = new Random().Next(1,17);

        if (i == iStart && j < column - jEnd - 1)
            j++;
        else if (j == column - jEnd - 1 && i < lines - iEnd - 1)
            i++;
        else if (i == lines - iEnd - 1 && j > jStart)
            j--;
        else
            i--;

        if ((i == iStart + 1) && (j == jStart) && (jStart != column - jEnd - 1))
        {
            iStart++;
            iEnd++;
            jStart++;
            jEnd++;
        }
        k++;
    }

    PrintArrayInt(matrix);

}

// Задача 61: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void Zadacha61()
{
    Random rand = new Random();    
    int line = new Random().Next(4,7);
    int column = line;
    int[,] matrix = new int [line, column];
    int[,] matrixReloaded = new int [line, column];
    int[,] matrixRevolutions = new int [line, column];

    FillArrayInt(matrix);
    PrintArrayInt(matrix);
    Console.WriteLine();
    FillArrayInt(matrixReloaded);
    PrintArrayInt(matrixReloaded);
    Console.WriteLine();
    FillArrayOp(matrix, matrixReloaded, matrixRevolutions);
    PrintArrayInt(matrixRevolutions);
}


void FillArrayOp(int[,] matrix, int[,] matrixReloaded, int[,] matrixRevolutions)
{   
    for (int i = 0; i < matrixRevolutions.GetLength(0); i++)
    {   
        for (int j = 0; j < matrixRevolutions.GetLength(1); j++)
        {   
            int sum = 0;
            for (int k = 0; k < matrixRevolutions.GetLength(1); k++)
            {
                int a = matrix[j, k];
                int b = matrixReloaded[k, i];
                sum = sum + a*b;
                
                matrixRevolutions[j, i] = sum;
            }
        }
    }
}


//Zadacha54();
//Zadacha56();
//Zadacha58();
//Zadacha61();