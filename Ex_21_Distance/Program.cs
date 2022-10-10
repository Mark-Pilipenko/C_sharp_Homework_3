// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int mist = 1;
while (mist == 1)
{
    try
    {
        Console.Write("Введите x точки А: ");
        double xa = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите y точки А: ");
        double ya = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите z точки А: ");
        double za = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите x точки B: ");
        double xb = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите y точки B: ");
        double yb = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите z точки B: ");
        double zb = Convert.ToDouble(Console.ReadLine());
        double dist = Math.Sqrt(Math.Pow((xa - xb), 2) + Math.Pow((ya - yb), 2) + Math.Pow((za - zb), 2));
        dist = Math.Round(dist, 2);
        Console.WriteLine("Расстояние между точками: " + dist);
        mist = 0;
    }
    catch
    {
        Console.WriteLine("Ошибка ввода!");
    }
}