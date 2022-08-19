Console.WriteLine("Введите три числа.");
Double number1 = Convert.ToDouble(Console.ReadLine());
Double number2 = Convert.ToDouble(Console.ReadLine());
Double number3 = Convert.ToDouble(Console.ReadLine());

double max = 0;

if(number1 > max) max = number1;
if(number2 > max) max = number2;
if(number3 > max) max = number3;

Console.Write(max);
Console.WriteLine(" - самое большое число.");