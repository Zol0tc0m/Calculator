string txt;
do
{
    Console.WriteLine("выберите действие.");
    Console.WriteLine("1. Сложение.");
    Console.WriteLine("2. Вычитание.");
    Console.WriteLine("3. Умножение.");
    Console.WriteLine("4. Деление.");
    Console.WriteLine("5. Возведение в степень.");
    Console.WriteLine("6. Квадратный корень из первого числа.");
    Console.WriteLine("7. Один процент из первого числа.");
    Console.WriteLine("8. Факториал первого числа.");
    Console.WriteLine("9. Закрыть программу.");
    txt = Console.ReadLine();
    Console.WriteLine("введите первое число.");
    string inp1 = Console.ReadLine();
    int x = Convert.ToInt32(inp1);
    Console.WriteLine("введите второе число.");
    string inp2 = Console.ReadLine();
    int y = Convert.ToInt32(inp2);
    if (txt == "1")
    {
        int otvet = x + y;
        Console.WriteLine("ответ:");
        Console.WriteLine(otvet);
    }
    else if (txt == "2")
    {
        int otvet = x - y;
        Console.WriteLine("ответ:");
        Console.WriteLine(otvet);
    }
    else if (txt == "3")
    {
        int otvet = x * y;
        Console.WriteLine("ответ:");

        Console.WriteLine(otvet);
    }
    else if (txt == "4")
    {
        int otvet = x / y;
        Console.WriteLine("ответ:");
        Console.WriteLine(otvet);
    }
    else if (txt == "5")
    {
        double pow5 = Math.Pow(x, y);
        Console.WriteLine("ответ:");
        Console.WriteLine(pow5);
    }
    else if (txt == "6")
    {
        double sprt = Math.Sqrt(x);
        Console.WriteLine("ответ:");
        Console.WriteLine(sprt);
    }
    else if (txt == "7")
    {
        int otvet = x * y / 100;
        Console.WriteLine("ответ:");
        Console.WriteLine(otvet);
    }
    else if (txt == "8")
    {
        int num = x;
        int fact = 1;
        for (int i = 1; i <= num; i++)
        {
            fact *= i;
        }
        Console.WriteLine("ответ:");
        Console.WriteLine(fact);
    }
} while (txt != "9");