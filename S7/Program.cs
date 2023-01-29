
int[,] Cr2a() //Создание двумерного размера
{
    Console.Write("input a rows: ");
    int R = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a columns: ");
    int C = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a min: ");
    int Min = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a max: ");
    int Max = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[R,C];

    for (int i = 0; i < R; i++ )
        for (int j = 0; j < C; j++)
            array[i,j] = new Random().Next(Min,Max + 1);
        return array;
}

void P2A (int[,] array) // печать двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++ )
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        Console.Write(array[i,j] + "  ");
    Console.WriteLine();
    }
     Console.WriteLine();
}

void P2Ad (double[,] array) // печать двумерного массива действительные числа
{
    for (int i = 0; i < array.GetLength(0); i++ )
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        Console.Write(array[i,j] + "\t");
    Console.WriteLine();
    }
     Console.WriteLine();
}
/*
int [,] A1 = Cr2a();
P2A(A1);
*/
/*3адайте двумерный массив размера m на n,
 каждый элемент в массиве находится по формуле: 
Aij = i+j. 
Выведите полученный массив на экран.
*/
/*
    Console.Write("input a rows: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a columns: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[m,n];
    P2A(array);
    
    for (int i = 0; i < m; i++ )
        for (int j = 0; j < n; j++)
            array[i,j] = i + j;
    P2A(array);

    Задайте двумерный массив.
    Найдите элементы, у которых оба индекса чётные, 
    и замените эти элементы на их квадраты.
    */
/*
 int[,] f (int[,] array)
 {
    for (int i = 0; i < array.GetLength(0); i++ )
        for (int j = 0; j < array.GetLength(1); j++)
             if (array[i,j] % 2 == 0 && array[i,j] !=0 ) array[i,j] = array[i,j] * array[i,j]; 
            
        return array;
 }

int[,] a = Cr2a();
P2A(a);
f(a);
P2A(a);
*/
//Задайте двумерный массив. 
//Найдите сумму элементов,
 //находящихся на главной диагонали
//с индексами (0,0); (1;1) и т.д.
/*
int f (int[,] array)
 {
    int t = 0;
    for (int i = 0; i < array.GetLength(0); i++ )
        for (int j = 0; j < array.GetLength(1); j++)
             if (i == j ) t = t + array[i,j]; 
            
        return t;
 }


int[,] a = Cr2a();
P2A(a);
int sum = f(a);
Console.Write(sum);

Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
*/
/*
double[,] Cr2ad() 
{
    {
    Console.Write("input a rows: ");
    int R = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a columns: ");
    int C = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a min: ");
    int Min = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a max: ");
    int  Max = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[R,C];
    Random rand = new Random();
    
    for (int i = 0; i < R; i++ )
        for (int j = 0; j < C; j++)
        {
            double x = rand.Next(Min, Max) + rand.NextDouble();
            array[i,j] = Math.Round(x,2);
        }
        return array;
}
}
double[,] a = Cr2ad();
P2Ad(a);
*/
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
//, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] a = Cr2a();
P2A(a);
Console.Write("input a rows: ");
int R = Convert.ToInt32(Console.ReadLine());
Console.Write("input a columns: ");
int C = Convert.ToInt32(Console.ReadLine());
if (R > a.GetLength(0)) Console.WriteLine("No number"); 
if (C > a.GetLength(1)) Console.WriteLine("No number"); 
else Console.WriteLine(a[R,C]); 
*/

//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

void f (int[,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++ )
    { double a = 0;
        for (int j = 0; j < array.GetLength(1); j++) 
        a = a + array[i,j];
        Console.Write($"Average of row {i + 1} is {a / array.GetLength(0) }");
    Console.WriteLine();
    }
     Console.WriteLine();
}

int[,] a = Cr2a();
P2A(a);
f(a);
