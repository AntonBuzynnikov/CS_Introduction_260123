// 1. С клавиатуры вводится целое число. Вывести квадрат числа
System.Console.Write("Введите число: ");
int a = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Квадрат числа = "+a*a);
/*Решение с семинара
string? s;
s = Console.ReadLine();
int a;
a = Convert.ToInt32(s);
checked      --(проверка на выполнение)
{
Console.WriteLine(a*a);
}
*/