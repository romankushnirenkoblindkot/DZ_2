//  Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8 
// 918 -> 1

Console.WriteLine("Введите трёхначное число: ");
string number = Console.ReadLine();
Console.WriteLine("Вторая цифра этого числа: " + number[1]);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberOf = Convert.ToString(number);
if (numberOf.Length > 2)
{
  Console.WriteLine("Третья цифра этого числа: " + numberOf[2]);
}
else {
  Console.WriteLine("Третьей цифры нет");
}


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.WriteLine("Введите номер дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber <= 7 && dayNumber >=1)
{
   if (dayNumber == 1)
   {
       Console.WriteLine("нет");
   }
   if (dayNumber == 2)
   {
       Console.WriteLine("нет");
   }
      if (dayNumber == 3)
   {
       Console.WriteLine("нет");
   }
   if (dayNumber == 4)
   {
       Console.WriteLine("нет");
   }
   if (dayNumber == 5)
   {
       Console.WriteLine("нет");
   }
   if (dayNumber == 6)
   {
       Console.WriteLine("да");
   }
   if (dayNumber == 7)
   {
       Console.WriteLine("да");
   }

}
else
{
   Console.WriteLine("Error");
}
