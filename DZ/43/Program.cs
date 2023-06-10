string Coincidence()
{
    double y1, y2;
    Console.WriteLine("Даны уравнения прямых y = k1 * x + b1, y = k2 * x + b2\nВведите b1 из формулы:");
    double b1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите k1 из формулы:");
    double k1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите b2 из формулы:");
    double b2 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите k2 из формулы:");
    double k2 = int.Parse(Console.ReadLine()!);
        if (k1 == k2)
    {
        return "Совпадений не найдено";
    }
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    string result = "(" + x.ToString("F4") + ", " + y.ToString("F4") + ")";
    return result;
}

// Очищаем консоль
Console.Clear();

// Вызываем метод Count() и сохраняем результат в переменную j
string j = Coincidence();

// Выводим результат в консоль
Console.WriteLine(j);