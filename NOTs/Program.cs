/*
string[,] table = new string[2,5];
// String.Empty
// table [0,0] table [0,1] table [0,2] table [0,4]
// table [1,0] table [1,1] table [1,2] table [1,4]
table[1, 2] = "слово";
for (int rows = 0; rows < 2; rows++)
{
 for (int columns = 0; columns < 5; columns++)
 {
 Console.WriteLine($"-{table[rows, columns]}-");
 }
}

void PM (int[,] matr)
{

for (int i = 0; i < matr.GetLength(0); i++)
{
 for (int j = 0; j < matr.GetLength(1); j++)
 {
 Console.Write($"{matr[i, j]} ");
 }
 Console.WriteLine();
}
}

void FM (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i,j] = new Random().Next(1,10);
            }


    }
}

int[,] matix = new int[3, 4];
PM(matix);
FM(matix);
Console.WriteLine();
PM(matix);
*/
/*
int f (int N)
{
    if(N == 1) return 1;
    else return N * f(N-1);
}

Console.WriteLine(f(20));
*/
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

void RA  (int [] array) // Реверс массива
{
        for(int i = 0,  j = array.Length - 1; i < j; i++, j--)
        {
            int temp = array[i];
            array[i]= array[j];
            array[j] = temp;
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

Console.Write($"array:{A1} ");

/*

*/


int Mi(int[,] array,int x, int y)
{
    int max = array[x,y];
        for (int j = y; j < array.GetLength(1); j++)
        {
            if (max < array[x,j]) 
            {
                max = array[x,j];
            }
        }
        return max;
}

int[,] CraF() 
{
    int R = 5;
    int C = 5;
    int Min = 0;
    int Max = 100;   
     int[,] array = new int[R,C];

    for (int i = 0; i < R; i++ )
        for (int j = 0; j < C; j++)
            array[i,j] = new Random().Next(Min,Max + 1);
        return array;
}



int[,] CraF() 
{
    int R = 5;
    int C = 5;
    int Min = 0;
    int Max = 100;   
     int[,] array = new int[R,C];

    for (int i = 0; i < R; i++ )
        for (int j = 0; j < C; j++)
            array[i,j] = new Random().Next(Min,Max + 1);
        return array;
}



int[,] CraF() 
{
    int R = 5;
    int C = 5;
    int Min = 0;
    int Max = 100;   
     int[,] array = new int[R,C];

    for (int i = 0; i < R; i++ )
        for (int j = 0; j < C; j++)
            array[i,j] = new Random().Next(Min,Max + 1);
        return array;
}


