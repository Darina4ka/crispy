Console.WriteLine ("Введите пятизначное число");
try
{
    int a = Convert.ToInt32 (Console.ReadLine ());
    if (a > 9999)
    {
        if (a % 10 == a / 10000 && (a % 100) / 10 == (a / 1000) % 10)
        {
            Console.WriteLine ("Да");
        }
        else 
        {
            Console.WriteLine ("Нет");
        }
    }
    else 
    {
        Console.WriteLine ("Нужно ввести пятизначное число!");
    }
}
catch
{
    Console.WriteLine ("Нужно ввести пятизначное число!");
};
