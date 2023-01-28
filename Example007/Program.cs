// 7. Выяснить является ли число чётным.
System.Console.Write("Введите число: ");
int a = Int32.Parse(System.Console.ReadLine());
if (a % 2 == 0)
    System.Console.WriteLine("Число чётное");
else
    System.Console.WriteLine("Число нечётное");
