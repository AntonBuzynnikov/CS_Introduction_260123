// 5. С клавиатуры вводятся три числа. Найти максимальное из трех чисел
System.Console.Write("Введите первое число: ");
int a = Int32.Parse(System.Console.ReadLine());
System.Console.Write("Введите второе число: ");
int b = Int32.Parse(System.Console.ReadLine());
System.Console.Write("Введтие третье число: ");
int c = Int32.Parse(System.Console.ReadLine());
int max;
max = a;
if (b > max)
    max = b;
if (c > max)
    max = c;
System.Console.WriteLine("max = "+ max);