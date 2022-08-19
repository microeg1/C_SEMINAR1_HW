Console.WriteLine("Введите число.");
int number1 = Convert.ToInt32(Console.ReadLine());
int count = 1;

while(count < number1)
{
    if(count % 2 == 0)
    {
        Console.Write(count);
        Console.Write(", ");
        count++;
    }
    else
    {
        count++;
    }

}