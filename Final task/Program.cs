string[] arr1 = new string[5] {"Russ", "55", "Geek", "You", "Brains"};
string[] arr2 = new string[arr1.Length];
void SecondArrWithIF(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[count] = arr1[i];
        count++;
        }
    }
}
void PrintArr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
SecondArrWithIF(arr1, arr2);
System.Console.WriteLine("Первоначальный массив");
PrintArr(arr1);
System.Console.WriteLine("Новый массив");
PrintArr(arr2);
