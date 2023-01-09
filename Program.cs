// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// double  [,] CreateArray(int rows, int cols, int min, int max){
//     double [,] array = new double [rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i,j] = new Random().NextDouble();
//         }
//     }
//     return array;
// }
// void ShowArray(double [,] array){
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }
// Console.Write("Enter numb of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of cols: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of min elem: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of max elem: ");
// int max = Convert.ToInt32(Console.ReadLine());
// double [,] array = CreateArray(rows, cols, min, max);
// ShowArray(array);
          
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Console.Write("Введите размеры массива m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размеры массива n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];
 
// for (int i = 0; i < array.GetLength(0); i++) 
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//         array [i, j] = Convert.ToInt32(new Random().Next(0,21));  
// }
 
// for (int i = 0; i < array.GetLength(0); i++) 
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//         Console.Write(array[i,j] + " ");
//         Console.WriteLine();
// }
 
//  Console.WriteLine("Введите координату а: ");
//  int a = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите координату b: ");
//  int b = Convert.ToInt32(Console.ReadLine());
//  if (a>m && b>n && a>n && b>m){
//  Console.WriteLine("такого числа нет");
//  }
//  else
//  {
//  Console.WriteLine($"{array[a,b]}");
//  }

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Console.WriteLine("Enter n:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter m:");
// int m = Convert.ToInt32(Console.ReadLine());
// double [,] arr = new double [n, m];
// double [] sum = new double [m];

// for (int i=0; i<n; i++)
// {
//     for(int j=0; j<m; j++)
//     {
//         arr[i, j] = new Random().Next(0, 10);

//         Console.Write(arr[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// for (int i=0; i<m; i++)
// {
//     for(int j=0; j<n; j++)
//     {
//         sum[i] += arr[j, i];
//     }
// }

// for (int i=0; i<m; i++)
// {
//     Console.Write((sum[i] / n)  + " ");
// }