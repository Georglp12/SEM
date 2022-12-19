//напишите программу которая проверяет
//является ли первое квадратом второго
/*
Console.WriteLine("Input a FRS number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a SEC number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int quad2 = num2 * num2;
if (num1 == quad2) Console.WriteLine("Yes");
else Console.WriteLine ("No");
*/

// задача 2 прогамма на входе н а на выходе все целые
/*
Console.Write("Input N: ");
int N = Convert.ToInt32(Console.ReadLine());
int cur = -N;
while (cur<=N)
{
  Console.Write(cur + " ");  
  cur = cur + 1;
}
*/

// HOMEWORK
//Задача 2 

//Напишите программу, которая на вход принимает два числа
//и выдаёт, какое число большее, а какое меньше
/*
Console.Write("Input Num1: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Num2: ");
int Num2 = Convert.ToInt32(Console.ReadLine());
if (Num1 > Num2 ) Console.Write("Num1 > Num2: ");
if (Num1 < Num2 ) Console.Write("Num2 > Num1: ");
if (Num1 == Num2 ) Console.Write("Числа равны");
*/

//Задача 4
//Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел
/*
Console.Write("Введи первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи второе число: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи третье число: ");
int C = Convert.ToInt32(Console.ReadLine());
int max = A;
if (B > max) max = B;
if (C > max) max = C;
Console.Write(max);
*/

//Задача 6
// программу, которая на вход принимает число и выдаёт, 
//является ли число чётным 
//(делится ли оно на два без остатка
/*
Console.Write("Введи число: ");
int A = Convert.ToInt32(Console.ReadLine());
if (A % 2 == 0) Console.Write("Число четное");
else Console.Write("Число Нечетное");
*/

//Задача 8: Напишите программу, которая на вход принимает число (N)
//а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введи число: N ");
int N = Convert.ToInt32(Console.ReadLine());
int cont = 0;
while (cont < N )
{
    Console.Write(cont + ", ");
    cont = cont + 2;
}
if (N % 2 == 0) Console.Write(N);

