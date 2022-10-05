/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
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


//подсчет кол-ва четных числе в массиве
int GetEvenElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.Clear();
Console.WriteLine("Введите размерость массива");
int size = int.Parse(Console.ReadLine() ?? "");
int[] array = InitArray(size);
string result = string.Join(", ", array);
Console.WriteLine($"Сгенерированный массив: [{result}]");
int evenNum = GetEvenElements(array);
Console.WriteLine($"Кол-во четных числе в массиве: {evenNum}");