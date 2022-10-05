/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

//метод, который получает сумму нечетных эл-в
int GetSummOfOddElements(int[] array)
{
    int summ = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        summ += array[i];
    }
    return summ;
}

// создаем массив размера size и заполняем значениями в диапазоне -100 до 100
int[] InitArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(-100, 101);
    }
    return array;
}

Console.Clear();
Console.WriteLine("Введите размерость массива");
int size = int.Parse(Console.ReadLine() ?? "");
int[]array = InitArray(size);
var result = string.Join(", ", array);
Console.WriteLine($"Сгенерированный массив: [{result}]");
int oddNum = GetSummOfOddElements(array);
Console.WriteLine($"Сумма элементов массива на нечетных позициях = {oddNum}");