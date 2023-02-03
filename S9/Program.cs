

//Задайте значение N. Напишите программу,
//которая выведет все натуральные числа в промежутке от 1 до N.
/*
void SN (int num)
{
if (num > 1 ) SN(num - 1);
Console.Write(num + " ");
}
SN(5);
*/
//Напишите программу, которая будет принимать на вход число
//и возвращать сумму его цифр.
/*
int SoN(int num)
{
if (num != 0) return SoN( num / 10) + num % 10;
return 0;
}
Console.Write(SoN(1234));
*/
//Задайте значения M и N.
//Напишите программу, которая выведет все натуральные числа
//в промежутке от M до N.
/*
Console.Write("input a n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("input a n: ");
int m = Convert.ToInt32(Console.ReadLine());

void SN (int num)
{
if (num > n ) SN(num - 1);
Console.Write(num + " ");
}
SN(m);
*/

//Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B.
/*
int SoN(int a, int b)
{
if (b != 0) return SoN(a, b - 1) * a;
else return 1;
}
Console.Write(SoN(2,6));
*/
//Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1.
//Выполнить с помощью рекурсии.
/*
void SN (int num)
{
Console.Write(num + " ");
if (num > 1 ) SN(num - 1);
}
SN(5);
*/
/*
Задача 64: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.
*/
/*
void SN (int num)
{
Console.Write(num + " ");
if (num > 1 ) SN(num - 1);
}
Console.Write("input a n: ");
int n = Convert.ToInt32(Console.ReadLine());
SN(n);
/*

/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
/*
Console.Write("input a m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input a m: ");
int n = Convert.ToInt32(Console.ReadLine());

void NNS (int m, int n, int sum)
{
if (m > n)
{
Console.WriteLine(sum);
return;
}
sum = sum + (m++);
NNS(m, n, sum);
}
NNS(m, n, 0);
*/
/*
Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
Console.Write("input a m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input a m: ");
int n = Convert.ToInt32(Console.ReadLine());
int fA = f(m, n);
Console.Write(fA);
int f(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0) return f(m - 1, 1);
else return f(m - 1, f(m, n - 1));
}
