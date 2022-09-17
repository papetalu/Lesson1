Console.Clear();
Console.Write("Введите значение 1: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение 2: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x * x == y)
Console.WriteLine("yes");
else
Console.WriteLine("no");