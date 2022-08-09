Console.WriteLine("Введите натуральное положительное число");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < num; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + "  ");
    }
}