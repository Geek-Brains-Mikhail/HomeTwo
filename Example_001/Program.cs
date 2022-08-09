/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

//Code//
int WriteNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());

}
int NumberMiddle(int number)
{
    int result = ((number/100) * 100) +  (number%10);
    return (number-result) /10;

}

Console.WriteLine(NumberMiddle(WriteNumber("Введите трехзначеное число: ")));