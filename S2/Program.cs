/*
int CutNumber(int num)
{
    int a = num / 100;
    int b = num % 10;

    int result = a * 10 + b; 
    return result;
}

int RN = new Random().Next(100,1000);
int NN = CutNumber(RN);

Console.WriteLine($"From {RN} To {NN}");
*/

//Напишите программу, которая выводит случайное
//число из отрезка [10, 99]
//и показывает наибольшую цифру числа.

/*
int MN (int X)
{
    int a = X / 10;
    int b = X % 10;
    int max = a;
    if (a < b) max = b;
    return max;
}
int Num = new Random().Next(10,100);
int BN = MN(Num);
Console.WriteLine($"number is {Num} and biggest num  is  {BN}");
*/
//Напишите программу, которая будет принимать 
//на вход два числа и выводить, является ли 
//второе число кратным первому.
/*
bool SN(int X, int Y)
{
    if (Y % X == 0) return true;
    else return false;
}
Console.WriteLine("Write 1st: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write 2nd: ");
int n2 = Convert.ToInt32(Console.ReadLine());
bool ANS = SN(n1,n2);
if (ANS == true) Console.WriteLine($"{n2} Кратное {n1}");
else Console.WriteLine($"{n2} некратное {n1}");
*/

//Напишите программу, которая принимает на вход два числа и проверяет,
//является ли одно число квадратом другого.
/*
bool QN (int x, int y)
{
    if (x * x == y) return true;
    if (y * y == x) return true;
    else return false;
    
}
Console.WriteLine("Write 1st: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write 2nd: ");
int n2 = Convert.ToInt32(Console.ReadLine());
bool ANS = QN(n1,n2);
if (ANS == true) Console.WriteLine($" является квадратом");
else Console.WriteLine($"неявляется квадратом");
*/


      ///HomeWork


///Задача 10 
///Напишите программу, которая принимает на вход трёхзначное число 
///и на выходе показывает вторую цифру этого числа.
/*
int NT (int x)
{
int a = x / 10;
a = a % 10;
return a;
}
int RN = new Random().Next(100,1000);
int NN = NT(RN);
Console.WriteLine($" Заданое число {RN}");
Console.WriteLine($" Вторая цифра в заданом {NN}");
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

/*

*/
//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет,
//является ли этот день выходным.

bool WKND(int x)
{
    if (x == 6) return true;
    if (x == 7) return true;
    else return false;  
}
Console.Write("Введи номер дня недели ");
int wn = Convert.ToInt32(Console.ReadLine());
bool ANS = WKND(wn);
if (wn > 7)  Console.Write("некорректный день недели ");
else if (ANS == true) Console.Write("выходной ");
else Console.Write("не выходной");
