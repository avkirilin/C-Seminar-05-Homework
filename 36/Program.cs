// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях.
Console.Clear();
int[] GetRandomArray(int size, int minValue, int maxValue)      //метод получения массива заданной длины, заполняемый случайными числами
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}
void PrintArray(int[] array)                                    //метод выведения значений на экран
{
    Console.WriteLine($"[{String.Join(", ", array)}]");
}
int SumNumInOddPositions(int[] array)                               //метод поиска кол-ва четных чисел в массиве
{
    int result = 0;
    for (int i = 0; i < array.Length; i=i+2)
    {
        result += array[i];
    }
    return result;
}
System.Console.WriteLine("Введите кол-во значений в массиве");
int count = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Массив будет заполнен автоматически случайными положительными двузначными числами:");
int[] randomArray = GetRandomArray(count, 10, 100);
PrintArray(randomArray);
int sumNumInOdd = SumNumInOddPositions(randomArray);
System.Console.WriteLine($"Сумма чисел в заданном масиве стоящих на нечетных позициях равна: {sumNumInOdd}");