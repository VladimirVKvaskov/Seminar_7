/*

//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
	
Console.Clear();

Console.WriteLine("введите количество строк m");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов n");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[lines, columns];
Random(numbers);
PrintArray(numbers);
	
void Random(double[,] array)
	{
	    for (int i = 0; i < array.GetLength(0); i++)
	    {
	        for (int j = 0; j < array.GetLength(1); j++)
	        {
	            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
	        }
	    }
	}
	
void PrintArray(double[,] array)
	{
	    for (int i = 0; i < array.GetLength(0); i++)
	    {
	        Console.Write("[ ");
	        for (int j = 0; j < array.GetLength(1); j++)
	        {
	            Console.Write(array[i, j] + " ");
	        }
	        Console.Write("]");
	        Console.WriteLine("");
	    }
	}



//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
	
Console.Clear();
Console.WriteLine("введите номер строки");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int n = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [10,10];
Random(numbers);
	
	if (m > numbers.GetLength(0) || n > numbers.GetLength(1))
	{
	    Console.WriteLine("такого элемента нет");
	}
	else
	{
	    Console.WriteLine(numbers[m-1,n-1]);
	}
	
PrintArray(numbers);
	
void Random(int[,] array)
	{
	    for (int i = 0; i < array.GetLength(0); i++)
	        {        
	            for (int j = 0; j < array.GetLength(1); j++)
	            {
	                array [i,j] = new Random().Next(-100, 100)/10;
	            }   
	        }
	}
	
void PrintArray(int[,] array)
	{
	    for (int i = 0; i < array.GetLength(0); i++)
	    {
	        Console.Write("[ ");
	        for (int j = 0; j < array.GetLength(1); j++)
	        {
	            Console.Write(array[i,j] + " ");
	        }   
	        Console.Write("]");
	        Console.WriteLine(""); 
	    }
	}



//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();
Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
	
int[,] numbers = new int[n, m];
Random(numbers);
	
	
for (int j = 0; j < numbers.GetLength(1); j++)
	{
	    double average = 0;
	    for (int i = 0; i < numbers.GetLength(0); i++)
	    {
	        average = (average + numbers[i, j]);
	    }
	    average = average / n;
	    Console.Write(average + "; ");
	}
Console.WriteLine();
PrintArray(numbers);
	
	
	
void Random(int[,] array)
	{
	    for (int i = 0; i < array.GetLength(0); i++)
	    {
	        for (int j = 0; j < array.GetLength(1); j++)
	        {
	            array[i, j] = new Random().Next(0, 10);
	        }
	    }
	}
	
void PrintArray(int[,] array)
	{
	
	    for (int i = 0; i < array.GetLength(0); i++)
	    {
	        Console.Write("[ ");
	        for (int j = 0; j < array.GetLength(1); j++)
	        {
	            Console.Write(array[i, j] + " ");
	        }
	        Console.Write("]");
	        Console.WriteLine("");
	    }
	}

*/
