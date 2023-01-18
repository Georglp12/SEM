

/*int GetSum (int num)
{
    int sum = 0;

    for(int cur = 0; cur <= num; cur++)
    sum += cur;
    return sum;
}
Console.Write("input a num: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = GetSum(a);
Console.WriteLine(result);

Напишите программу, которая принимает на вход число N и выдаёт
произведение чисел от 1 до N.

Павел Гуляев: Напишите программу, которая принимает на вход число
и выдаёт количество цифр в числе.
*/
/*
int f (int num)
{
    int sum = 1;
    for (int i = 1; i <= num; i++)
    sum = sum * i; 
    return sum;
}
Console.Write("input a num: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = f(a);
Console.WriteLine(result);
*/
/*
int i = 0;
int f(int num)
{
while (num != 0)
{
   
   num = num / 10;
   i = i + 1;
}
    return i;
}
Console.Write("input a num: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = f(num);
Console.WriteLine(result);
*/
/*=
int[] Cra(int size, int min, int max) 
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++);
        array [i] = new Random().Next(min, max +1);  
    return array;
}
void SA (int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
Console.Write("input a length of array: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] NA = Cra(Length, min, max);
SA(NA);
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
void SA (int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("input a length of array: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] NA = Cra(Length, min, max);
SA(NA);
*/

//Напишите цикл, который принимает на вход два числа (A и B) 
//возводит число A в натуральную степень B.
/*

Console.Write("input numer A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max: B ");
int B = Convert.ToInt32(Console.ReadLine());

int f (int  x, int y)
{
    int s = 1;
    for(int j = 0; j < y; j++)
    s = s * x;
    return s;
}
int result = f(A,B);
Console.Write(result);
*/

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


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
void SA (int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
void SumA (int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    sum = sum + array[i] ;
    Console.Write(sum);
}

Console.Write("input a length of array: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] NA = Cra(Length, min, max);
SA(NA);
SumA(NA);
*/

//Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
int[] A(int size) 
{
    int[] array = new int[size];
    
        for (int y = 0; y < size; y++)
            {
                Console.Write("input element of array: ");
                int x = Convert.ToInt32(Console.ReadLine());
                array[y] = x;
                
            }
             return array;
}
void SA (int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
Console.Write("input a length of array: ");
int Length = Convert.ToInt32(Console.ReadLine());
int[] NA = A(Length);
SA(NA);
