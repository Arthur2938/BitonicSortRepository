//namespace DataGenerator;

//class Program
//{
//    public static void GenerateDataSets()
//    {
//        Random rnd = new Random();
//        StreamWriter sw = new StreamWriter("X:\\КФУ\\АсД\\2 сем\\Семестровка\\DataSets.txt");
//        for (int set = 0; set != 100; set++)
//        {
//            int SetCount = rnd.Next(100, 10000);
//            for (int i = 0; i != SetCount; i++)
//            {
//                sw.Write(rnd.Next(Int32.MinValue, Int32.MaxValue) + " ");
//            }
//            sw.WriteLine();
//        }
//        sw.Close();
//    }
//    static void Main(string[] args)
//    {
//        GenerateDataSets();
//        Console.WriteLine("Hello, World!");
//    }
//}
