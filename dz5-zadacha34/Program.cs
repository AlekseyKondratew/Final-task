Console.WriteLine("Задайте количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];
int count = 0;
for (int index = 0; index < n; index++)
{
    array [index]= new Random().Next(100,1000);
    if (array[index] % 2 == 0)
    count++;

}
Console.WriteLine(string.Join(" ", array));
Console.WriteLine($"Количество чётный элементов в массиве: {count}");
