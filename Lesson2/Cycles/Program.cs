Console.Write("Пожалуйста, введите количество расходов: ");
int numbers = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= numbers; i++)
{
    Console.Write($"Введите сумму расхода {i}: ");
    int s = int.Parse(Console.ReadLine());
    sum += s;
 }

Console.WriteLine($"Общая сумма расходов за месяц составляет:{sum}");