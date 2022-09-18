Console.Clear();

int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
   array[i] = new Random().Next(-10, 11);
// [-10, 10]
Console.WriteLine("[" + string.Join(", ", array) + "]");



void f(ref int x) // процедура
{
   x = x + 5;
}

int n = 10;
Console.WriteLine(n);
f(ref n);
Console.WriteLine(n);



int f(int n, int m) // n != m
{
   if (n > m)
      return n; // !!! завершает работу на этом этапе, если верно

   return m;
}

Console.WriteLine(f(23, 7));



// 9 task
Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int MaxCifra = n % 10;
while (n > 0)
{
   n = n / 10;
   if (n % 10 > MaxCifra)
      MaxCifra = n % 10;
}
Console.WriteLine(MaxCifra);





string a = Convert.ToString(new Random().Next(100, 1000));
Console.Write("Число выбрано - " + a + ",а результат - ");
Console.WriteLine(a[0] + "" + a[2]);
