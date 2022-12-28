//Задача 19
//Напишите программу, которая принимает 
//на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

//Может и не самое лучшее решение, но что успел на коленке
//болел сильно. пытаюсь нагнать
/*
int F1(int x, int y, int z)
{
    int m = y - z; 
    int i = 0;
         while (i < m)
         {
         x = x / 10;
         i++;
        }
        x = x % 10;
        return x;
}

Console.Write("Введи число: N ");
int a = Convert.ToInt32(Console.ReadLine());
int d = (int)Math.Log10(a) + 1;
int cont = 0;
int m = 1;
int m1 = d - cont;
double e = d / 2;
int p = 0;
while (cont < e )
{
    if (F1(a,d,m) == F1(a,d,m1)) p = 0;
    else p = 1;
    cont++;
    m++;
    m1 = d - cont;
}
if (p == 0) Console.Write("Yes");
else Console.Write("No");
 */   


//Задача 21
//Напишите программу, которая 
//принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
/*
Console.WriteLine("Введите данные для точки А: ");
Console.Write("Координата X: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координата Y: ");
double  y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координата Z: ");
double  z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите данные для точки B: ");
Console.Write("Координата X: ");
double  x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координата Y: ");
double  y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координата Z: ");
double  z2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"A({x1},{y1},{z1})");
Console.WriteLine($"B({x2},{y2},{z2})");
double AB = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));
Console.WriteLine(AB);
*/

//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
/*
Console.WriteLine("Введите N: ");
double  N = Convert.ToDouble(Console.ReadLine());
int c = 1;
while (N + 1 > c)
{
    double ans = Math.Pow(c,3);
    Console.Write("  " + ans);
    c++;
}
*/