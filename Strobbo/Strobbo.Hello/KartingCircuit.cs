namespace Strobbo.Hello
{
    public class KartingCircuit(string[] karts)
    {
        private string[] Karts { get; } = karts;

        public void RandomizeKarts()
        {
            Random random = new();
            random.Shuffle(Karts);
        }

        public string[,] AssignGroups(int groups = 6)
        {
            string[,] result = new string[groups, Karts.Length / groups];
            int start = 0;

            for (int i = 0; i < groups; i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = Karts[start++];
                }
            }

            return result;
        }

        public static void PrintGroup(string[,] groups)
        {
            for (int i = 0; i < groups.GetLength(0); i++)
            {
                Console.Write($"Group {i + 1}: ");
                for (int j = 0; j < groups.GetLength(1); j++)
                {
                    Console.Write($"{groups[i, j]}  ");
                }
                Console.WriteLine();
            }
        }

    }
}
