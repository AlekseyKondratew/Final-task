int [] array = new int [ new Random().Next(1,5)];
int sum = 0;
for (int index = 0; index < array.Length; index++)
{
    array[index] = new Random().Next(0,100);
    if(index % 2 > 0)
       sum += array[index];
}
Console.WriteLine(string.Join ("", array));
Console.WriteLine($"Сумма элементов на нечётных позициях = {sum}");

