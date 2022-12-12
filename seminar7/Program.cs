//Задача 48: Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
//Выведите полученный массив на экран.
//m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5
Console.WriteLine("Введите два числа: ");
int m = Convert.ToInt32 (Console.ReadLine());
int n = Convert.ToInt32 (Console.ReadLine());
int [,] array = new int [m,n];
for ( int i=0; i<array.GetLength(0); i++)
{
    for ( int j=0; j<array.GetLength(1); j++) 
    {   
        array[i, j] = i + j; 
        Console.Write ($"{array[i, j]}");

    }
    Console.WriteLine ();
}
// 46
Console.WriteLine("Введите два числа: ");
int m = Convert.ToInt32 (Console.ReadLine());
int n = Convert.ToInt32 (Console.ReadLine());
int [,] array = new int [m,n];
for ( int i=0; i<array.GetLength(0); i++) 
{
    for ( int j=0; j<array.GetLength(1); j++) 
    { 
        array[i, j] = new Random().Next (1, 10);
        Console.Write ($"{array[i, j]}");
    }
    Console.WriteLine ();
}

//51
Console.WriteLine("Введите число строк массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());
int[,] nums = new int[m,n];
Random rnd = new Random();
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        nums[i,j] = rnd.Next(2, 10);
        Console.Write($"{nums[i,j]}, ");
    }
    Console.WriteLine();
}

int summ = 0;
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        if(i == j)
        summ += nums[i,j];
    }
}
Console.WriteLine($"Сумма членов, находящихся на диагонали {summ}");
// 49
Console.WriteLine("Введите два числа");
int m =Convert.ToInt32 (Console.ReadLine());
int n =Convert.ToInt32 (Console.ReadLine());
int[,] array = new int [m,n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(1,10);
        Console.Write($"{array[i,j]}");
    }
    Console.WriteLine ();
}
Console.WriteLine ();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i%2==0 && j%2==0)
        array[i,j]*=array[i,j];
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine ();
}

