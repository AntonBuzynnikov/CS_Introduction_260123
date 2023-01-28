// 11. Дано число больше 9, вывести второе число с конца
System.Console.Write("Введите число: ");
int a = Int32.Parse(System.Console.ReadLine());
int b;

b = a % 100;

System.Console.Write("Второе число с конца: ");
System.Console.Write(b / 10);