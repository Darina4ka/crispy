double lengthBetween(int xa, int ya, int za, int xb, int yb, int zb)
{
double xres = (xb * xb)-(2 * xa * xb) + (xa * xa);
double yres = (xb * xb)-(2 * xa * xb) + (xa * xa);
double zres = (xb * xb)-(2 * xa * xb) + (xa * xa);
double res = Math.Sqrt(xres + yres + zres);
return res;
}

Console.WriteLine("Введите координаты первой точки");
int xa = Convert.ToInt32(Console.ReadLine());
int ya = Convert.ToInt32(Console.ReadLine());
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
int xb = Convert.ToInt32(Console.ReadLine());
int yb = Convert.ToInt32(Console.ReadLine());
int zb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Расстояние между точками = {lengthBetween(xa,ya,za,xb,yb,zb)}");