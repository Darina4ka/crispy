Console.WriteLine ("Введите целое число");
try
{
    int N = Convert.ToInt32 (Console.ReadLine ());
    int i = 1;
    while (i<=N)
    {                                                               
        Console.WriteLine (i*i*i);
        i++;
    }
}
catch 
{
     Console.WriteLine ("Нужно ввести целое число!");
}