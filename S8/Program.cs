//Задайте двумерный массив.
//Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.


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
        Console.Write(array[i,j] + "\t");
    Console.WriteLine();
    }
     Console.WriteLine();
}
/*
void chrow (int[,] array)
        {
            Console.Write("input a row 1: ");
            int r1 = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write("input a row 2: ");
            int r2 = Convert.ToInt32(Console.ReadLine()) - 1;

            if (r1 >= 0 && r1 < array.GetLength(0) &&
                r2 >= 0 && r2 < array.GetLength(0) &&
                r1 != r2)
                {
                     for (int j = 0; j < array.GetLength(1); j++) 
                     {
                        int temp = array[r1,j];
                        array [r1,j] = array[r2,j];
                        array [r2,j] = temp;
                     }
                }
                 return ;
        }


int[,] a = Cr2a();
P2A(a);
chrow(a);
P2A(a);
*/
//Задайте двумерный массив.
//Напишите программу, 
//которая заменяет строки на столбцы.
/*
void crc (int[,] array)
        {
            
           
                    for (int i = 0; i < array.GetLength(0); i++ )
                         for (int j = 0; j < i ; j++)
                            {
                            int temp = array[i,j];
                            array [i,j] = array[j,i];
                            array [j,i] = temp;
                            }
                return;
        }

int[,] a = Cr2a();
P2A(a);
crc(a);
P2A(a);

*/


//Из двумерного массива целых чисел удалить строку и столбец,
//на пересечении которых расположен наименьший элемент.


/*
int[,] delRC (int[,] array, min) 
{

    for (int i = 0; i < R; i++ )
        for (int j = 0; j < C; j++)
            if array[i,j] = new Random().Next(Min,Max + 1);
        return array;
}
*/
/*
 int mini (int[,] array) 
 {
    int min = array[0,0];
    int ai = 0;
   
        for (int i = 0; i < array.GetLength(0); i++ )
        {
            for (int j = 0; j < array.GetLength(1); j++) 
            {
                if (min > array[i,j])
                {
                    min = array[i,j];
                    ai = i;
                    
                   
                    
                }
            }
        }
return ai;
}

 int minj (int[,] array) 
 {
    int min = array[0,0];
    int aj = 0;
   
        for (int i = 0; i < array.GetLength(0); i++ )
        {
            for (int j = 0; j < array.GetLength(1); j++) 
            {
                if (min > array[i,j])
                {
                    min = array[i,j];
                    aj = j;
                    
                   
                    
                }
            }
        }
return aj;
}
 
int[,] DelRC (int[,] array, int Ii, int Ij) 
{
    int[,] Narray = new int[array.GetLength(0)-1, 4];
    for (int i = 0; i < array.GetLength(0); i++ )
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        if (i != Ii && j != Ij) 
        {
            Narray[i,j] = array[i,j];
        }
    }
return Narray;
} 


int[,] a = Cr2a();
P2A(a);
int Ii = mini(a);
int Ij = minj(a);
Console.WriteLine($"[{Ii+1},{Ij+1}]");
DelRC(a,Ii,Ij);
P2A(a);
*/

//Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

/*
int[,] NR(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++ )
     {
        
        for (int j = 0; j < array.GetLength(0) - 1; j++)
            {
                if ( array[i,j] < array[i,j + 1] )
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,j + 1];
                    array[i,j + 1] = temp;
                }
                
            }
 
     }
return array;
}

int[,] a = Cr2a();
P2A(a);
NR(a);
P2A(a);
*/

//Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку
//с наименьшей суммой элементов.

/*
int f1 (int[,] array)
{
    int sum = 0;
    int ix = 0;
    for (int i = 0; i < array.GetLength(0); i++ )
        {  
            int suma = 0;
            if ( suma > sum) ix++;
            for (int j = 0; j < array.GetLength(1) ; j++)
                {
                    suma = suma + array[i,j] ;
                    if (suma > sum) 
                    {
                        sum = suma;
                        ix = i;
                    }
                }
            
        }
return ix;
}

int[,] a = Cr2a();
P2A(a);
int g = f1(a);
Console.Write($" Наибольшая сумма элементов  в строке {g+1}");
*/
/*
Задайте две матрицы.
Напишите программу, 
которая будет находить 
произведение двух матриц.
*/
/*
int[,] Matr22 () 
{
    int R = 2;
    int C = 2;
    int Min = 0;
    int Max = 10;   
     int[,] array = new int[R,C];

    for (int i = 0; i < R; i++ )
        for (int j = 0; j < C; j++)
            array[i,j] = new Random().Next(Min,Max + 1);
        return array;
}


int[,] MF(int[,] array1, int[,] array2)
{
    int[,] array3 = new int[2, 2];
        for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++) 
                        {
                            array3[i,j] += array1[i,k] * array2[k,j];
                        }
                   
                }
            }
return array3;
}

int[,] MatrixA = Matr22();
int[,] MatrixB = Matr22();
Console.WriteLine("Matrix 1");
P2A(MatrixA);
Console.WriteLine("Matrix 2");
P2A(MatrixB);

int[,] MatrixC = MF(MatrixA,MatrixB);

P2A(MatrixC);
*/

///формируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу,
//которая будет построчно выводить массив,
//добавляя индексы каждого элемента
/*

int[,,] Cr3a() //Создание 3xмерного размера
{
    int Min = 0;
    int Max = 10;
    int[,,] array = new int[2,2,2];
    for (int i = 0; i < 2; i++ )
        for (int j = 0; j < 2; j++)
            for (int k = 0; k < 2; k++)
            array[i,j,k] = new Random().Next(Min,Max + 1);
        return array;
}

void P3A (int[,,] array) // печать двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++ )
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < 2; k++)
            {
                Console.Write(array[i,j,k] + $"({i},{j},{k})   " + "\t");
            }   
        } 
       
    Console.WriteLine();
    }
     Console.WriteLine();
}


int[,,] a1 = Cr3a(); 
P3A(a1);
*/

/*
Напишите программу, 
которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
*/


int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
  