//Сгенерировать трехзначное число и удалить второе

int n = new Random().Next(100, 1000);
int n1 = n / 100; // первая цифра числа
int n2 = n % 10; // третья цифра числа
Console.WriteLine(n);
Console.WriteLine(n1);
Console.WriteLine(n2);
Console.WriteLine(n1 * 10 + n2);
