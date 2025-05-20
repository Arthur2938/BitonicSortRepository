namespace TimeCostMeter;

using Bitonic_Sort;


public class SetParameters
{
    public int SetLength { get; set; }
    public double TimeSpan { get; set; }
    public int IterationsCount { get; set; }

    public SetParameters(int setlength, long timeSpan, int iterationsCount)
    {
        SetLength = setlength;
        TimeSpan = timeSpan;
        IterationsCount = iterationsCount;
    }
}
public class Program
{
    public static SetParameters[] GenerateSetParameters()
    {
        StreamReader sr = new StreamReader("X:\\КФУ\\АсД\\2 сем\\Семестровка\\DataSets.txt");
        int count = File.ReadLines("X:\\КФУ\\АсД\\2 сем\\Семестровка\\DataSets.txt").Count();
        var sets = new SetParameters[count];
        for (int i = 0; i != count; i++)
        {
            int[] set = sr.ReadLine().Split(' ').SkipLast(1).Select(str => Int32.Parse(str)).ToArray();
            int iterCount;
            double timeSpan;
            Sorter.Bitonic_sort(set, out timeSpan, out iterCount);
            sets[i] = new SetParameters(set.Length, timeSpan, iterCount);
        }
        return sets;
        // throw new NotImplementedException();
    }
    public static SetParameters[] ReturnCollection()
    {
        SetParameters[] collection = GenerateSetParameters();
        for (int i = 0; i != 99; i++)
        {
            var setParameters = GenerateSetParameters();
            collection = collection.Select((element, k) => new SetParameters(element.SetLength,
            element.TimeSpan + setParameters[k].TimeSpan,
            element.IterationsCount)).ToArray();
        }
        for (int i = 0; i != collection.Count(); i++)
        {
            collection[i] = new SetParameters(collection[i].SetLength,
            collection[i].TimeSpan / 100, collection[i].IterationsCount);
        }
        return collection;
    }
    static void Main(string[] args)
    {
        // SetParameters[] collection = GenerateSetParameters();
        // for (int i = 0; i != 99; i++)
        // {
        //     var setParameters = GenerateSetParameters();
        //     collection = collection.Select((element, k) => new SetParameters(element.SetLength,
        //     element.TimeSpan + setParameters[k].TimeSpan,
        //     element.IterationsCount)).ToArray();
        // }
        // for (int i = 0; i != collection.Count(); i++)
        // {
        //     collection[i] = new SetParameters(collection[i].SetLength,
        //     collection[i].TimeSpan / 100, collection[i].IterationsCount);
        // }
        // Console.WriteLine("Hello, World!");
    }
}
