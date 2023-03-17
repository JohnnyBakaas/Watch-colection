namespace Objektifisering.Models
{
    public class Watchcolection
    {
        private List<Watch> watches = new List<Watch>();

        public Watchcolection()
        {
            watches.Add(new Watch("Omega Moon Swatch MISSION TO MARS", "Swatch", "Quartc", 2022, "Stock", new List<string>() { "Cronograph" }));
            watches.Add(new Watch("Blue dive watch", "SEIKO 5 SPORT", "Automatic", 2018, "Blue lether", new List<string>() { "Date" }));
            watches.Add(new Watch("S&G dive watch", "INVICTA", "Automatic", 2019, "S&G oyster bracelet", new List<string>() { "Date" }));
            watches.Add(new Watch("TV watch", "SEIKO 5 SPORT", "Automatic", 1970, "Oyster bracelet", new List<string>() { "Date" }));
        }

        public void DisplayColection()
        {
            int index = 0;
            Console.WriteLine();
            foreach (Watch watch in watches)
            {
                Console.WriteLine(index);
                watch.PrintInfo();
                Console.WriteLine();
                index++;
            }
        }

        public List<Watch> WatchList()
        {
            return watches;
        }

        public void TakeWatchFromColection(int index, Person person)
        {
            if (index != -1)
            {
                person.Watch = watches[index];
                watches.RemoveAt(index);
            }
        }

        public void ReturnWatchToColection(Person person)
        {
            watches.Add(person.Watch);
            person.Watch = null;
        }
    }
}
