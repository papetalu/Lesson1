// 9 task
Console.Clear();
// [10, 99]
int n = new Random().Next(10, 100);
int n1 = n / 10; // первая цифра числа
int n2 = n % 10; // вторвя цифра числа
Console.WriteLine(n);
if (n1 > n2)
   Console.WriteLine(n1);
else if (n1 < n2)
   Console.WriteLine(n2);
else
   Console.WriteLine("Цифры равны");
