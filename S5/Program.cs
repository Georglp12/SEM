//программа сумма отрицательных элементов в массив
/*
int SumNeg  (int array)
{
    int sum;
    for(int i = 0; i < array.Lenght; i++)
        if (array[i] < 0) sum += array[i];
    return sum;
}
int[] Cra(int size, int min, int max) 
{
    int[] array = new int[size];
    Random rand = new Random();
        for (int y = 0; y < size; y++)
            {
                array[y] = rand.Next(min, max);
                
            }
             return array;
}
Console.Write("input a length of array: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] NA = Cra(Length, min, max);
int result = SumNeg(NA);
Console.Write(result);

int[] Cra(int size, int min, int max) 
{
    int[] array = new int[size];
    Random rand = new Random();
        for (int y = 0; y < size; y++)
            {
                array[y] = rand.Next(min, max);
                
            }
             return array;
}

void PA (int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int SumNeg  (int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if (array[i] < 0) sum += array[i];
    return sum;
}

Console.Write("input a length of array: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] NA = Cra(Length, min, max);
PA(NA);
int result = SumNeg(NA);
Console.Write(result);
*/
//написать программу, заменяющую положительные элементы массива
//на отрицательные и наоборот.
/*
int[] Cra(int size, int min, int max) 
{
    int[] array = new int[size];
    Random rand = new Random();
        for (int y = 0; y < size; y++)
            {
                array[y] = rand.Next(min, max);
                
            }
             return array;
}

void PA (int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[] IA (int[]array) 
{
    for(int i = 0; i < array.Length; i++)
        array[i] = array[i] * -1;
    return array;
}

Console.Write("input a length of array: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] A1 = Cra(Length, min, max);
PA(A1);
int[] A2 = IA(A1);
PA(A2);
*/

//Написать программу, определяющую, присутствует ли заданное число в массиве.
/*
int[] Cra(int size, int min, int max) 
{
    int[] array = new int[size];
    Random rand = new Random();
        for (int y = 0; y < size; y++)
            {
                array[y] = rand.Next(min, max);
                
            }
             return array;
}

void PA (int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void FNA (int[]array, int N) 
{
    int temp = 0;
    for(int i = 0; i < array.Length; i++)
        if (array[i] == N)
        {
            temp++;
            Console.WriteLine ($"Number {N} equal {i+1} element of array ");
        }
}

Console.Write("input a length of array: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number for search: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] A1 = Cra(Length, min, max);
PA(A1);
FNA(A1,N);
*/

//Павел Гуляев: Задать массив из n элементов, определить кол-во элементов,
//принадлежащих отрезку [a,b].
/*

int[] Cra(int size, int min, int max) 
{
    int[] array = new int[size];
    Random rand = new Random();
        for (int y = 0; y < size; y++)
            {
                array[y] = rand.Next(min, max);
                
            }
             return array;
}

void PA (int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}


void FSL(int[]array, int x, int y) 
{
    for(int i = 0; i < array.Length; i++)
        if (array[i] >= x && array[i] <= y )
        {
            Console.WriteLine ($"element of array {i+1} is part of line segment");
        }
}

Console.WriteLine("Create array: ");
Console.Write("input a length of array: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] A1 = Cra(Length, min, max);
Console.WriteLine("Create line segment: ");
Console.Write("input point a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("input point b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("array: ");
PA(A1);
Console.WriteLine($"line segment: [{a},{b}] ");
FSL(A1,a,b);
*/
/*
Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество
чётных чисел в массиве.
*/
/*
int[] Cra(int size, int min, int max) 
{
    int[] array = new int[size];
    Random rand = new Random();
        for (int y = 0; y < size; y++)
            {
                array[y] = rand.Next(min, max);
                
            }
             return array;
}

void PA (int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void FA (int[] array)
{
    int temp = 0;
    for(int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) temp++;
    Console.WriteLine($"Array have a {temp} even number");
}
Console.WriteLine("Create array: ");
Console.Write("input a length of array: ");
int Length = Convert.ToInt32(Console.ReadLine());
int min = 100;
int max = 999;
int[] A1 = Cra(Length, min, max);
Console.Write("array: ");
PA(A1);
FA(A1);
*/

//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
/*
void PA (int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[] Cra(int size, int min, int max) 
{
    int[] array = new int[size];
    Random rand = new Random();
        for (int y = 0; y < size; y++)
            {
                array[y] = rand.Next(min, max);
                
            }
             return array;
}

void SFN (int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if (array[i] % 2 != 0) sum = sum + array[i];
    Console.WriteLine($"sum of not even number is {sum}");
}

Console.WriteLine("Create array: ");
Console.Write("input a length of array: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] A1 = Cra(Length, min, max);
PA(A1);
SFN(A1);
*/

void PA (double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

double[] Crad(int size, int min, int max) 
{
    double[] array = new double[size];
    Random rand = new Random();
        for (int y = 0; y < size; y++)
            {
                array[y] = rand.Next(min, max) + rand.NextDouble();
            }
             return array;
}

double MinA(double[] array)
{
    double MinA = array[0];
    for(int i = 1; i < array.Length; i++) 
    if (MinA > array[i] ) MinA = array[i];
    return MinA;
}

double MaxA(double[] array)
{
    double MaxA = array[0];
    for(int i = 1; i < array.Length; i++) 
    if (MaxA < array[i] ) MaxA = array[i];
    return MaxA;
}



Console.WriteLine("Create array: ");
Console.Write("input a length of array: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max: ");
int max = Convert.ToInt32(Console.ReadLine());
double[] A1 = Crad(Length, min, max);
Console.Write("Array:"); 
PA(A1);
Console.WriteLine(" "); 
double MaxNA = MaxA(A1);
double MinNA = MinA(A1);
double  Ans = MaxNA - MinNA;
Console.WriteLine($"Diff between Max number and Min Number of array is {Ans}"); 

