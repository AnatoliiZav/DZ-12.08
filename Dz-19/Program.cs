/* Console.WriteLine("Введите пятизначное число : ");
int N = int.Parse(Console.ReadLine());

if (N > 9999 && N <100000) 
{
    int a = N % 100; 
    int b = N / 1000; 
    int a1 = a / 10; 
    int b1 = a % 10; 
    int b2 = b / 10; 
    int a2 = b % 10;
    Console.WriteLine($"{a}, {b}, {a1}, {a2}, {b1}, {b2}");
    if(a1 == a2 && b1 == b2)
    { 
        Console.Write($"Число {N} является палиндромом");
    }
    else
    {
        Console.Write($"Число {N} не является палиндромом");
    }
}
else
{
    Console.Write($"Число {N} не является пятизначным");
}