Console.WriteLine("Введите значение переменной a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение переменной b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение переменной c");
int c = Convert.ToInt32(Console.ReadLine());
if ((a > b) & (a > c))
{
    Console.WriteLine("Наибольшее значение у переменной a: " + a);
} 
else if ((b > a) & (b > c))
{
    Console.WriteLine("Наибольшее значение у переменной b: " + b);
}
else
{
    Console.WriteLine("Наибольшее значение у переменной c: " + c);
}