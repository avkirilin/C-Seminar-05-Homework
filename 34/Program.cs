// Задайте массив, заполненный случайными положительными трехзначными числами. Напишите программу, которая покажет количество четных чисел в массиве.
Console.Clear();
int[] GetRandomArray(int size, int minValue, int maxValue)              //метод получения массива заданной длины, заполняемый случайными числами
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
int CountEvenNumbers(int[] array)                               //метод поиска кол-ва четных чисел в массиве
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) result += 1;
    }
    return result;
}
System.Console.WriteLine("Введите кол-во значений в массиве");
int count = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Массив будет заполнен автоматически случайными положительными трехзначными числами:");
int[] randomArray = GetRandomArray(count, 100, 1000);
PrintArray(randomArray);
int evenNumbers = CountEvenNumbers(randomArray);
System.Console.WriteLine($"В массиве кол-во четных чисел равно {evenNumbers}");