// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
Console.Clear();
double[] GetRandomArray(int size)      //метод получения массива заданной длины, заполняемый случайными числами
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = Math.Round((new Random().Next(-99, 100) + new Random().NextDouble()), 2);
    }
    return result;
}
void PrintArray(double[] array)                           //метод выведения значений на экран
{
    Console.WriteLine($"[{String.Join(", ", array)}]");   
}
double MinMagnitude(double[] array)                       //метод поиска минимального вещественного числа в массиве
{
    double result = 100;
    for (int i = 0; i < array.Length; i++)
    {
        if (result > array[i]) result = array[i];
    }
    return result;
}
double MaxMagnitude(double[] array)                        //метод поиска максимального вещественного числа в массиве
{
    double result = -100;
    for (int i = 0; i < array.Length; i++)
    {
        if (result < array[i]) result = array[i];
    }
    return result;
}
System.Console.WriteLine("Введите кол-во значений в массиве");
int count = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Массив будет заполнен автоматически случайными положительными двузначными числами:");
double[] randomArray = GetRandomArray(count);
PrintArray(randomArray);
double diffMinMaxValue = MaxMagnitude(randomArray) - MinMagnitude(randomArray);
System.Console.WriteLine($"Максимальное значение массива больше минимального на {diffMinMaxValue:f3}");