// Задача 1: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную 
// степень B. Реализовать через функции.


int Prompt(string message)
{
    Console.WriteLine($"{message} > ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int DegreeB(int numberA, int numberB)
{
    int stepB = 1;
    for (int i = 1; i<=numberB; i++)
        {
        stepB = stepB * numberA;
        }
    return stepB;
}

int numberA = Prompt("Введите число А "); 

int numberB = Prompt("Введите число В "); 

int digital = DegreeB(numberA, numberB);
System.Console.WriteLine($"{digital}");