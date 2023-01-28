// Задача 2: Напишите программу, 
// которая принимает на вход число и выдаёт сумму цифр в числе. 
// Реализовать через функции.

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SumOfDigits(int n)
{
    int sum = 0;
    int ostatok = 0;
    while (n >0)
    {
        if(n%10!=0)
        {
            ostatok=n%10;
        }
        else
        {
            ostatok=n/10;
        }
        sum = sum + ostatok;
        n=n/10;
    }
    return sum;
}
int number = Prompt("Введите число");

int digital = SumOfDigits(number);
System.Console.WriteLine($"{digital}");
