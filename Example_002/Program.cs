// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

while(number > 999)
{
    number = number /10;
}
if(number/100 ==0)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(number%10);
}