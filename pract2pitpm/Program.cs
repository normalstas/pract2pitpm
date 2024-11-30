using ClassLibrary1;
Console.Write("Введите первое число: ");
string input1 = Console.ReadLine();
int number1 = int.Parse(input1);


Console.Write("Введите второе число: ");
string input2 = Console.ReadLine();
int number2 = int.Parse(input2);


int sum = Class1.Sum(number1,number2);


Console.WriteLine($"Сумма {sum}");