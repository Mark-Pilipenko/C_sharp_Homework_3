Console.Write("Введите натуральное число: ");
string noun = Console.ReadLine();
int n = noun.Length;
bool a = false;
for (int i = 0; i < n / 2; i++)
{
    if (noun[i] == noun[n - 1 - i]) a = true;
    else a = false;
}
if (a) Console.WriteLine("Это число - палиндром!");
else Console.WriteLine("Это число не является палиндромом!");