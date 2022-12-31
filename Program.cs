// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7   -2   -0,2
// 1  -3,3  8   -9,9
// 8   7,8 -7,1  9
/*
double[,] CreateRandom2DArray()
{
    Console.Write("Input a number of M: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number of N: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];
    for(int i = 0; i < rows; i++) 
    {
        for(int j = 0; j < columns; j++) 
        
            array[i,j] = new Random().NextDouble() * 100;
        
    }  
    return array;
}

void Show2dArray(double[,] array)
{
    for(int i =0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j]+ " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}


double[,] myArray = CreateRandom2DArray();
Show2dArray(myArray);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет
/*
int[,] Create2DArray()  
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)          
    {
        for(int j = 0; j < columns; j++)  
        {
            array[i,j] = i + j;
        }
        
    }  
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i =0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j]+ " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ValueElements(int[,] array)
{
    Console.Write("Input a number of pos1: ");
    int pos1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number of pos2: ");
    int pos2 = Convert.ToInt32(Console.ReadLine());
   
    if(pos1 > array.GetLength(0) || pos2 > array.GetLength(1))
    {
        Console.WriteLine($"{pos1} {pos2}  -> числа с такими индексами в массиве нет");
    }
    else 
    {
        Console.WriteLine(array[pos1,pos2]);
    }
}
       


int[,] myArray = Create2DArray();
Show2dArray(myArray);
ValueElements(myArray);

*/
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateRandom2DArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number of elements Value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number of elements Value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++) 
    {
        for(int j = 0; j < columns; j++) 
        
            array[i,j] = new Random().Next(minValue, maxValue);
        
    }  
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i =0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j]+ " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SumNum(int[,] array)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            {
                sum = sum + array[i, j];
            }
            
        }
        Console.Write($"{sum / array.GetLength(0)}, "); 
    }  
}


int[,] myArray = CreateRandom2DArray();
Show2dArray(myArray);
SumNum(myArray);
