Console.WriteLine("Введите первую координату по х");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите вторую координату по х");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите первую координату по у");
double yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите вторую координату по у");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите первую координату по z");
double zb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите вторую координату по z");
double za = Convert.ToDouble(Console.ReadLine());
double result = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2)) + Math.Pow((zb - za), 2);
Console.WriteLine(Math.Round(result,2));



