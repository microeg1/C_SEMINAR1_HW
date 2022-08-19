Console.WriteLine("Введите два числа.");
Double number1 = Convert.ToDouble(Console.ReadLine());
Double number2 = Convert.ToDouble(Console.ReadLine());
if(number1 > number2)
{
    Console.Write(number1);
    Console.WriteLine(" - большее число.");
}
else
{
    Console.Write(number2);
    Console.WriteLine(" - большее число.");
}