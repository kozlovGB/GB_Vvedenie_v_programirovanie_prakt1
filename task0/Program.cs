Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());
    if (a/b == b)
        {
            Console.WriteLine($"Число a = {a} является квадратом числа b = {b}");
        }
    else 
        {
            Console.WriteLine($"Число a = {a} не является квадратом числа b = {b}");
        }