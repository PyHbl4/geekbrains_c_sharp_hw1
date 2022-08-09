Console.WriteLine("Введите значение переменной a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение переменной b");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("Переменная a (" + a + ") больше, чем переменная b (" + b + ")");
}
else
{
    Console.WriteLine("Переменная b (" + b + ") больше, чем переменная a (" + a + ")");
}