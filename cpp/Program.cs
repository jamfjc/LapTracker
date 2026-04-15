namespace CP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine()!.Split();
            int n = int.Parse(line[0]);
            int m = int.Parse(line[1]);

            int[] timesTotal = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] lapTimes = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
                timesTotal[i] = lapTimes.Sum();
            }
            bool Improving = true;
            for (int i =1; i<n;i++)
            {
                if (timesTotal[i] >= timesTotal[i - 1])
                {
                    Improving = false;
                    break;
                }

            }
            Console.WriteLine(Improving.ToString().ToLower());
        }
    }
}
