Console.Write ("Введите координату х для точки A ");
double xa = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите координату y для точки А ");
double ya = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите координату z для точки А ");
double za = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите координату х для точки В");
double xb = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите координату y для точки В");
double yb = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите координату z для точки В");
double zb = Convert.ToInt32 (Console.ReadLine());
int AB;
try
{
    Math.Pow (xb , 2);
    Math.Pow (xa , 2);
    Math.Pow (yb , 2);
    Math.Pow (ya , 2);
    Math.Pow (zb , 2);
    Math.Pow (za , 2);
    AB = sqrt();
}
catch
{
Console.WriteLine("Надо было вводить именно целые числа");
}