// 2. С клавиатуры вводятся 2 вещественных числа.Проверить является ли одно из них квадратом другого
System.Console.WriteLine("Введите первое число: ");
double a = Double.Parse(System.Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
double b = Double.Parse(System.Console.ReadLine());
if (a*a == b)
    System.Console.WriteLine($"{a}*{a}={b}");
if (b*b == a)
    System.Console.WriteLine(a+" является квадратом "+b);