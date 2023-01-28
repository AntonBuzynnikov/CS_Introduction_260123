// 8. Вывести на экран числа от -N до N
System.Console.Write("Введите число: ");
int N  = Int32.Parse(System.Console.ReadLine());
int i;
i = -N;
while (i <= N)
{   
    System.Console.Write(i+" ");
    i++;
}