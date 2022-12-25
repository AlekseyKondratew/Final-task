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
