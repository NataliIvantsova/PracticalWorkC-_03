

void FillArrya(int [] massiv)
{
    int length = 8; // ищем длину массива (переменная length) через инструмент Length
    for (int i = 0; i < length; i++)
    {
        massiv [i] = new Random().Next(1,3); 
    }

} 

void PrintArrya(int[] col)// метод который будет печатать массив
{
    int count = 8; //количество элементов массива col
    for (int j = 0; j < count; j++)
    {
      Console.WriteLine(col[j]);//будем выводить на экран(консоль) значение текущего элемента
    }
  
}

int[] array = new int[8];// массив arrya ссодержит 8 элементов || 
// //new int[8] -  создай новый массив в котором будет 8 элементов/ 

FillArrya(array);//таким образом мы определили массив из 8 элементов

PrintArrya(array); //PrintArrya(array); печатает массива из 8 чисел
