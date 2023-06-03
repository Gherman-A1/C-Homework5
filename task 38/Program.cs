// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. [3 7 22 2 78] -> 76

double[] GetArray(int size, double minValue, double maxValue)
{
    double[] res=new double[size];
    for(int i=0; i<size; i++)
        {
            res[i]=new Random().NextDouble()*(maxValue - minValue) + minValue;
            Console.Write($"{res[i]} ");
        }
    return res;
}

double GetDiffMaxMin(double[]arr)
{
    double diff=arr.Max()- arr.Min();
    return diff;
}

double []array=GetArray(4,-10,10);
Console.WriteLine();
Console.WriteLine($"Разность между максимальным и минимальным элементами: {GetDiffMaxMin(array)}");