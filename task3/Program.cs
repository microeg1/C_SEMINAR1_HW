Console.WriteLine("Введите число.");
int number1 = Convert.ToInt32(Console.ReadLine());

if(number1 % 2 == 0)
{
    Console.Write(number1);
    Console.WriteLine(" - чётное число");
}
else
{
    Console.Write(number1);
    Console.WriteLine(" - нечётное число");
}