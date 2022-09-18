Console.Clear();
Console.Write("Введите значение 1: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение 2: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x * x == y || y * y == x)
   Console.WriteLine("Yes");
else
   Console.WriteLine("No");