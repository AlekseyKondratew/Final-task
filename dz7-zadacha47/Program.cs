Console.WriteLine("Введите 2 числа: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double [,] a = new double[m,n];
Random random = new Random();
for (int i = 0; i < m; i++)
{
    for(int j =0; j < m; j++)
    {
        a[i,j] = random.NextDouble() + random.Next(-100,100);
        Console.Write("{0,6:F2}", a[i,j]);
    }
    Console.WriteLine();
}