Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Палиндром. Точно!!!");
    }
    else
    {
        Console.WriteLine($"{number} - Это число не является палиндромом");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - число не является пятизначным");
}
