/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
double[] getArray(int length, int start, int end)
{
    double[] array = new double[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(start, end + 1));
    }
    return array;
}
double differenceOfMaxAndMinNumbers(double[] array)
{
    double maxNumber = array[0];
    double minNumber = array[0];
    double difference = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minNumber)
        {
            minNumber = array[i];
        }
        else if(array[i] > maxNumber)
                {
                    maxNumber = array[i];
                }
    }
    difference = maxNumber - minNumber;
    return difference;
}
void printArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}
double[] array = getArray(6,-10,10);
printArray(array);
double difference = differenceOfMaxAndMinNumbers(array);
Console.WriteLine($"Разница между максимальным и минимальным числом массива равно {difference}");