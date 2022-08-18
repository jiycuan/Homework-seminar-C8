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
                if (matrix[i, k] < matrix[i, position]) position = k;
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
    Console.WriteLine("Номер строки с наименьшей суммой элементов: " + min);
}


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void Zadacha58()
{
    Random rand = new Random();    
    int line = new Random().Next(5,10);
    int column = new Random().Next(5,10);
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
            int a = matrix[i, j];
            int b = matrixReloaded[i, j];
            matrixRevolutions[i, j] = a*b;
        }
    }
}

//Zadacha54();
//Zadacha56();
//Zadacha58();