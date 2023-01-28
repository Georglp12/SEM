int[] Cra(int size, int min, int max)  // Создание массива
{
    int[] array = new int[size];
    Random rand = new Random();
        for (int y = 0; y < size; y++)
            {
                array[y] = rand.Next(min, max);
                
            }
             return array;
}

void PA (int[] array) // печать массива
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void PAd (double[] array) // печать массива
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void RA  (int [] array) // Реверс массива
{
        for(int i = 0,  j = array.Length - 1; i < j; i++, j--)
        {
            int temp = array[i];
            array[i]= array[j];
            array[j] = temp;
        }
}

/*
Console.WriteLine("Create array: ");
Console.Write("input a length of array: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] A = Cra(Length, min, max);
PA(A);
RA(A);
PA(A);
*/

/*
Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
*/


/*
Не используя рекурсию, 
выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: a и b.
*/
/*
bool f(int num1, int num2, int num3)
{
    return (num1 + num2 > num3) && (num2 + num3 > num1) && (num3 + num1 > num2);
}

Console.WriteLine("Create NUM1: ");
int N1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Create NUM2: ");
int N2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Create NUM3: ");
int N3 = Convert.ToInt32(Console.ReadLine());

if (f(N1,N2,N3)) Console.WriteLine("May be");
else Console.WriteLine("not");
*/
/*
void FB(double[] array, double a, double b)
        {
            array[0] = a;
            array[1] = b;
        
            for (int i = 2; i < array.Length; i++)
                {

                       array[i] =   array[i-1] + array[i-2];
                       Console.WriteLine(array[i]);
                }
                 return ;
        }

Console.WriteLine("Create a ");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Create b ");
double b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Create L Array (N): ");
int N = Convert.ToInt32(Console.ReadLine());
double[] A = new double[N]; 
PAd(A);
FB(A,a,b);
PAd(A);
*/
/*
int[] CA (int[] array)  // copy массива
{
    int[] Narray = new int [array.Length];
    
        for (int i = 0; i < array.Length; i++)
            {
                Narray[i] = array[i];
                
            }
             return Narray;
}



Console.Write("input a length of array: ");
int Length = Convert.ToInt32(Console.ReadLine());
int[] A = Cra(Length, 0, 100);
PA(A);
int[] b = CA(A);
PA(b);
PA(A);

Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
*/


/*
void f(int a) // ВВод
{
    int b = 0;
    for(int i = 0; i < a; i++)
    {
        Console.Write("input num: ");
        int M = Convert.ToInt32(Console.ReadLine());
        if (M == 0) b++;
       
    }
    
    Console.Write("number of 0 : ");
    Console.Write(b);

}

Console.Write("input M: ");
int M = Convert.ToInt32(Console.ReadLine());
f(M);
*/
// апишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями 
//y = k1 * x + b1,
//y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Create b1 ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Create k1 ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Create b1 ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Create k2 ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"{b1},{k1},{b2},{k2}");
double x = (b1-b2)/(k2-k1);
double y = (k2*b1-k1*b2)/(k2-k1);
Console.WriteLine($"{x},{y}");