// 4. По заданному с клавиатуры номеру дня недели вывести его название
System.Console.Write("Введите номер дня недели: ");
int number_day = Int32.Parse(Console.ReadLine());
if (number_day == 1)
    System.Console.WriteLine("Понедельник");
if (number_day == 2)
    System.Console.WriteLine("Вторник");
if (number_day == 3)
    System.Console.WriteLine("Среда");
if (number_day == 4)
    System.Console.WriteLine("Четверг");
if (number_day == 5)
    System.Console.WriteLine("Пятница");
if (number_day == 6)
    System.Console.WriteLine("Суббота");
if (number_day == 7)
    System.Console.WriteLine("Воскресенье");