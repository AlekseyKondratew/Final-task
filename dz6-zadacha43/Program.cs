double x = 0;
double y = 0;
Console.WriteLine("Введите b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2");
int k2 = Convert.ToInt32(Console.ReadLine());
if ((k1==k2)&&(b1==b2))
{
    Console.WriteLine("Прямые совпадают");
}
else if (k1==k2)
{
    Console.WriteLine("Прямые параллельны");
}
else
{
    x =(b1-b2)/(k1-k2);
    y =(k1*(b2-b1))/(k1-k2)+b1;
    Console.WriteLine("(x:{0},y:{1})",x,y);
}

