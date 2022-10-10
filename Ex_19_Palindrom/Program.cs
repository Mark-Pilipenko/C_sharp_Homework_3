// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int mist = 0;
while (mist == 0)
{
    try
    {
        Console.Write("Введите пятизначное число: ");
        int noun = Convert.ToInt32(Console.ReadLine());
        if (noun / 10000 != 0)
        {
            if (noun/10000 == noun % 10 && (noun /1000) % 10 == (noun%100)/10) Console.WriteLine("Это число - палиндром!");
            else Console.WriteLine("Это число не является палиндромом!");
            mist = 1;
        }
        else Console.WriteLine("Число не пятизначное!");
    }
    catch
    {
        Console.WriteLine("Ошибочный ввод!");
    }
}