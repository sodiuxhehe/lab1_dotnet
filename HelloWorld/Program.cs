
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Привет от ИСП-243!");
// Console.WriteLine("Автор: Курочкина Софья");
// Console.WriteLine("Год: 2026");

// int age = 18;
// double gpa = 4.5;
// bool isStudent = true;
// string name = "Софья";

// Console.WriteLine(name);
// Console.WriteLine(age);
// Console.WriteLine(gpa);
// Console.WriteLine(isStudent);

// var city = "Волгоград";
// var year = 2026;
// var pi = 3.14159;
// var isActive = true;

// string myName = "Софья";
// int myAge = 18;
// string myGroup = "ИСП-243";

// Console.WriteLine($"Меня зовут {myName}, мне {myAge} лет, я учусь в группе {myGroup}.");

// Console.Write("Введите ваш возраст: ");
// string input = Console.ReadLine();
// int age2 = int.Parse(input);
// Console.WriteLine($"Через 10 лет вам будет {age2 + 10} лет.");

// int x = 10;
// int y = 3;
// Console.WriteLine(x + y);
// Console.WriteLine(x - y);
// Console.WriteLine(x * y);
// Console.WriteLine(x / y);
// Console.WriteLine(x % y);

// string firstName = "Софа";
// string lastName = "Курочкина";
// string group = "ИСП-243";
// int birthYear = 2008;
// double gpa = 4.5;
// bool hasScholarship = true;


// int a = 15;
// int b = 4;

// Console.WriteLine($"Сумма: {a + b}");
// Console.WriteLine($"Разность: {a - b}");
// Console.WriteLine($"Произведение: {a * b}");
// Console.WriteLine($"Частное (int): {a / b}");
// Console.WriteLine($"Остаток: {a % b}");

// double result = (double)a / b;
// Console.WriteLine($"Частное (double): {result}");


// Console.WriteLine(Math.Abs(-5));
// Console.WriteLine(Math.Pow(2, 10));
// Console.WriteLine(Math.Sqrt(144));
// Console.WriteLine(Math.Max(10, 25));
// Console.WriteLine(Math.Min(10, 25));
// Console.WriteLine(Math.Round(3.567, 2));


// Console.WriteLine("Калькулятор");

// Console.Write("Введите первое число: ");
// double num1 = double.Parse(Console.ReadLine()!);

// Console.Write("Введите второе число: ");
// double num2 = double.Parse(Console.ReadLine()!);

// Console.WriteLine($"Сумма: {num1 + num2}");
// Console.WriteLine($"Разность: {num1 - num2}");
// Console.WriteLine($"Произведение: {num1 * num2}");

// if (num2 != 0)
// {
//     Console.WriteLine($"Частное: {num1 / num2}");
// }
// else
// {
//     Console.WriteLine("Деление на ноль невозможно!");
// }

// Console.WriteLine(int.MaxValue);
// Console.WriteLine(int.MinValue);

// Console.WriteLine(double.MaxValue);
// Console.WriteLine(double.MinValue);

// Console.Write("Введите число: ");
// string input = Console.ReadLine()!;

// int number1 = Convert.ToInt32(input);
// int number2 = int.Parse(input);

// Console.WriteLine($"Convert.ToInt32: {number1}");
// Console.WriteLine($"int.Parse: {number2}");

// int metr1 = 1;
// System.Int32 metr2 = 1;

// Console.WriteLine(metr1);
// Console.WriteLine(metr2);


Console.WriteLine("Добро пожаловать в анкету!");


Console.Write("Введите ваше имя: ");
string name = Console.ReadLine()!;

Console.Write("Введите вашу фамилию: ");
string surname = Console.ReadLine()!;

Console.Write("Введите вашу группу: ");
string group = Console.ReadLine()!;

Console.Write("Введите ваш год рождения: ");
int birthYear = int.Parse(Console.ReadLine()!);

Console.Write("Введите ваш средний балл (например, 4.5): ");
double gpa = double.Parse(Console.ReadLine()!);


int currentYear = 2026;
int age = currentYear - birthYear;

bool isExcellent = gpa >= 4.5;

string status;

if (isExcellent == true)
    status = "Отличник";
else
    status = "Хорошист";


Console.WriteLine("Ваша анкета");
Console.WriteLine($"Имя: {name} {surname}");
Console.WriteLine($"Группа: {group}");
Console.WriteLine($"Возраст: {age} лет");
Console.WriteLine($"Средний балл: {gpa}");
Console.WriteLine($"Статус: {status}");
Console.WriteLine($"Лет до 30: {30 - age}");

Console.WriteLine("Нажмите Enter для выхода...");
Console.ReadLine();
