// Задача 3: Напишите программу, которая выводит массив 
// из 8 элементов, заполненный случайными числами.
// Оформите заполнение массива и вывод в виде функции 
// (пригодится в следующих задачах). Реализовать через 
// функции. (* Доп сложность, “введите количество 
// элементов массива”, “Введите минимальный порог 
// случайных значений”, “Введите максимальный порог 
// случайных значений”)

 int Prompt(string message)
{
System.Console.Write($"{message}: ");
int result = Convert.ToInt32(Console.ReadLine());
return result;
}
int[] CreatArray(int X)
{
int[] array = new int[X];
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next();
}
return array;
}
void ShowArray(int[] array)
{
for (int j = 0; j < array.Length; j++)
{
Console.Write($"{array[j]}");
}
}

int X = Prompt("введите количество элементов массива ");
int [] array = CreatArray(X);
ShowArray (array);