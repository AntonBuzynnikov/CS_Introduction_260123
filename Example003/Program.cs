// 3. С клавиатуры вводятся два числа a и b. Найти максимальное из них.
System.Console.Write("Введите число a: ");
int a = Int32.Parse(System.Console.ReadLine());
System.Console.Write("Введите число b: ");
int b = Int32.Parse(System.Console.ReadLine());
if (a > b)
    System.Console.WriteLine("max = "+a);
else
    System.Console.WriteLine("max = "+b);