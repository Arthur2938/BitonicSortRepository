using System.Diagnostics;

namespace Bitonic_Sort;
class Program 
{ 
    static void Main() 
    { 

    }
}
public static class Sorter
{
    public static void Swap<T>(T[] arr, int i, int j)
    {
        T temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
    public static void Bitonic_sort(int[] array, out double timeSpan, out int iterationsCount)
    {
        Stopwatch sw = new Stopwatch();
        iterationsCount = 0;

        sw.Start();
        int sortLength = array.Length;
        for (int k = 2; k < sortLength * 2; k <<= 1)
        {
            bool m = (((sortLength - 1) / k + 1) & 1) != 0;

            for (int j = k >> 1; j > 0; j >>= 1)
            {
                for (int i = 0; i < sortLength; i++)
                {
                    iterationsCount++;
                    int ij = i ^ j;

                    if (ij > i && ij < sortLength)
                    {
                        bool ascending = ((i & k) == 0) == m;
                        bool descending = ((i & k) != 0) == m;

                        if ((ascending && array[i] > array[ij]) || (descending && array[i] < array[ij]))
                        {
                            Swap(array, i, ij); //swap indices i and ij
                        }
                    }
                }
            }
        }
        sw.Stop();
        timeSpan = sw.Elapsed.TotalMicroseconds;
    }
}
