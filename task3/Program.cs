Console.WriteLine("Введите число для проверки на четность");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine("Введенное число - четное");
}
else
{
    Console.WriteLine("Введенное число - нечетное");
}