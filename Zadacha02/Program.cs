Console.Clear();
Console.Write("Введите номер дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
    Console.Write("Ты издеваешься?! Попробуй заново: ");
    n = Convert.ToInt32(Console.ReadLine());

}
switch(n)
{
case 1:
Console.WriteLine("Понедельник");
break;
case 2:
Console.WriteLine("Вторник");
break;
case 3:
Console.WriteLine("Среда");
break;
case 4:
Console.WriteLine("Четверг");
break;
case 5:
Console.WriteLine("Пятница");
break;
case 6:
Console.WriteLine("Суббота");
break;
case 7:
Console.WriteLine("ВС");
break;
}