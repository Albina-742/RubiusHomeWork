Console.WriteLine("Введите целое число от 0 до 30000");
string Value = Console.ReadLine();
int year = Convert.ToInt32(Value);

if (year % 4 == 0 & year % 100 != 0 | year % 400 == 0)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}
