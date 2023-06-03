// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19 ; [-4, -6, 89, 6] -> 0

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res=new int[size];
    for(int i=0; i<size; i++)
        {
            res[i]=new Random().Next(minValue,maxValue+1);
            Console.Write($"{res[i]} ");
        }
    return res;
}

int GetOddSum(int[]arr)
{
    int sum=0;
    for(int i=0; i<arr.Length; i++)
    {
        if(i%2!=0) sum=sum+arr[i];
    }
    return sum;
}

int[]array=GetArray(10,-10,10);
Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечетных позициях: {GetOddSum(array)}");