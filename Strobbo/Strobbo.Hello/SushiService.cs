namespace Strobbo.Hello
{
    public static class SushiService
    {
        static List<Sushi> Sushis { get; }
        static int nextId = 3;
        static SushiService()
        {
            Sushis = new List<Sushi>
        {
            new Sushi { Id = 1, Name = "Yakitori chicken", SmellsFishy = false },
            new Sushi { Id = 2, Name = "Sake temaki", SmellsFishy = true }
        };
        }

        public static List<Sushi> GetAll() => Sushis;

        public static Sushi? Get(int id) => Sushis.FirstOrDefault(p => p.Id == id);

        public static void Add(Sushi sushi)
        {
            sushi.Id = nextId++;
            Sushis.Add(sushi);
        }

        public static void Delete(int id)
        {
            var sushi = Get(id);
            if (sushi is null)
                return;

            Sushis.Remove(sushi);
        }

        public static void Update(Sushi sushi)
        {
            var index = Sushis.FindIndex(p => p.Id == sushi.Id);
            if (index == -1)
                return;

            Sushis[index] = sushi;
        }

    }
}
