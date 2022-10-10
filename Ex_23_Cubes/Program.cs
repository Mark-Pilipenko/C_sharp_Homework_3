// Задача 23

// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int mist = 1;
while (mist == 1)
{
    try
    {
        Console.Write("Введите целое число N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        if (N > 0)
        {
            Console.Write("Кубы чисел от 1 до " + N + ": ");
            for (int i = 1; i <= N; i++)
            {
                if (i == N) Console.Write(Math.Pow(i, 3) + ".");
                else Console.Write(Math.Pow(i, 3) + ", ");
            }
            mist = 0;
        }
        else if (N < 0)
        {
            Console.Write("Кубы чисел от -1 до " + N + ": ");
            for (int i = -1; i >= N; i--)
            {
                if (i == N) Console.Write(Math.Pow(i, 3) + ".");
                else Console.Write(Math.Pow(i, 3) + ", ");
            }
            mist = 0;
        }
        else 
        {
            Console.WriteLine("Куб нуля есть нуль!");
            mist = 0;
        }
    }
    catch
    {
        Console.WriteLine("Ошибка ввода!");
    }
}