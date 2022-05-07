// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int indexMin = 9999;
int indexMax = 99999;

if (number <= indexMin || number > indexMax)
{
    Console.WriteLine("Ошибка! Введите пятизначное число");
    return;
}

string numberString = Convert.ToString(number);

if (numberString[0] == numberString[4] || numberString[1] == numberString[3])
{
    Console.WriteLine($"Введенное число {number} палиндром");
    return;
}
else
Console.WriteLine($"Введенное число {number} не является палиндромом");