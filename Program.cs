// программу, к-рая найдет точку пересечения двух прямых, заданных ур-ниями y=k1*x +b1; y=k2*x+b2. b1, k1, b2, k2 задаются пользователем.
Console.WriteLine("Для поиска пересечения двух прямых необходимо ввести четыре параметра");
Console.WriteLine();

Console.WriteLine("Введите переменную b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите переменную k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите переменную b2");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите переменную k2");
int k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.Write($"Точка пересечения = {GetLineCrossX(k1, k2, b1, b2)}; {GetLineCrossY(k1, k2, b1, b2)}");

double GetLineCrossX (double k1, double k2, double b1, double b2)
{
    double x = 0;
    x = (b2-b1)/(k1-k2);
    return x;
}

double GetLineCrossY (double k1, double k2, double b1, double b2)
{
    double y = 0;
    y = k1*((b2-b1)/(k1-k2))+b1;
    return y;
}

