Console.Clear();
Console.Write("Введите значение 1: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение 2: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x % y == 0)
{
   Console.WriteLine("Кратно");
}
else
{
   Console.WriteLine("не кратно");
   int z = x % y;
   Console.WriteLine(z);
}