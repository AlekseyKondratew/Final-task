Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int res = 0;
while (num>0)
{
    res=num%10;
    sum=sum+res;
    num/=10;
}
Console.WriteLine($"Сумма цифр числа = {sum}");








