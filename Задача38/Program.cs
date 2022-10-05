/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

[3 7 22 2 78] -> 76
*/
//создать массив вещ числе от 0 до 100
double[] InitArray(int size)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(0, 101);
    }
    return array;
}


//найти разницу между макс и мин числом массива
double Diff(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return (max - min);
}
Console.Clear();
Console.WriteLine("Введите размерость массива");
int size = int.Parse(Console.ReadLine() ?? "");
double[] array = InitArray(size);
var result = string.Join(", ", array);
Console.WriteLine($"[{result}]");
double difference = Diff(array);
Console.WriteLine($"разница между макс и мин числом массива = {difference}");