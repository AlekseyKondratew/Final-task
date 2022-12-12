double [] array = new double [new Random().Next(1,5)];
for (int i = 0; i < array.Length; i++)
{
    array[i]= new Random().Next(0,10);
}
double min = array[0];
double max = array[0];
for (int j = 0; j < array.Length; j++)
    if (array[j]>max)
        max = array[j];
    else if (array[j]<min)
        min = array[j];
Console.WriteLine(string.Join("", array));
Console.WriteLine($"Разница между максимальным и минимальным элементами массива {max-min}");

