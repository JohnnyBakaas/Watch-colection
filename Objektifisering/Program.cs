

using Objektifisering.Models;

namespace Objektifisering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Watchcolection watchcolection = new Watchcolection();
            Person Johnny = new Person();

            Loop(watchcolection, Johnny);

            Johnny.Talk();
        }

        public static void Loop(Watchcolection watchcolection, Person Johnny)
        {
            bool repet = true;
            Console.WriteLine();
            Console.WriteLine("Trykk 1 for å velge klokke");
            Console.WriteLine("Trykk 2 for å se hvilken klokke du har på deg");
            Console.WriteLine("Trykk Annet for å avslutte");
            Console.WriteLine();
            string UserInput = Console.ReadLine();
            Console.WriteLine();

            switch (UserInput)
            {
                case "1":
                    if (Johnny.Watch != null)
                    {
                        watchcolection.ReturnWatchToColection(Johnny);
                    }

                    watchcolection.DisplayColection();

                    int SelectedWatch = Johnny.SelectWatch(watchcolection.WatchList());
                    Console.Clear();

                    watchcolection.TakeWatchFromColection(SelectedWatch, Johnny);
                    break;

                case "2":
                    Johnny.Talk();
                    break;
                default:
                    repet = false;
                    break;
            }


            if (repet)
            {
                Loop(watchcolection, Johnny);
            }
        }
    }
}

