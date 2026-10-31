int a = 15;
int b = 4;

Console.WriteLine($"Сумма: {a + b}");
Console.WriteLine($"Разность: {a - b}");
Console.WriteLine($"Произведение: {a * b}");
Console.WriteLine($"Частное (int): {a / b}");
Console.WriteLine($"Остаток: {a % b}");

double result = (double) a / b;
Console.WriteLine($"Частное (double): {result}");


Console.WriteLine(Math.Abs(-5));
Console.WriteLine(Math.Pow(2, 10));
Console.WriteLine(Math.Sqrt(144));
Console.WriteLine(Math.Max(10, 25));
Console.WriteLine(Math.Min(10, 25));
Console.WriteLine(Math.Round(3.567, 2));


Console.WriteLine("Калькулятор");

Console.Write("Введите первое число: ");
double num1 = double.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
double num2 = double.Parse(Console.ReadLine());

Console.WriteLine($"Сумма: {num1 + num2}");
Console.WriteLine($"Разность: {num1 - num2}");
Console.WriteLine($"Произведение: {num1 * num2}");

if (num2 != 0)
    Console.WriteLine($"Частное: {num1 / num2}");
else
    Console.WriteLine("Деление на ноль невозможно!");
