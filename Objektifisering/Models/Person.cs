namespace Objektifisering.Models
{
    public class Person
    {
        public Watch Watch;

        public Person()
        {
            Watch = null;
        }

        public void Talk()
        {
            DescribeWatch();
        }

        private void DescribeWatch()
        {
            if (Watch != null)
            {
                Watch.PrintInfo();
            }
            else
            {
                Console.WriteLine("Du har ingen klokke på deg");
            }
        }

        public int SelectWatch(List<Watch> WatchColection)
        {

            Console.WriteLine();

            Console.WriteLine("Hvilken klokke vil du ha?");
            int UserSelectedWatch = GetUserInput(WatchColection);
            return UserSelectedWatch;
        }

        private bool IsDigitsOnlyOrEmty(string str)
        {
            if (str.Length == 0) return false;
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        private int GetUserInput(List<Watch> WatchColection)
        {
            string WatchSelectedInput = Console.ReadLine();
            if (IsDigitsOnlyOrEmty(WatchSelectedInput))
            {
                int WatchSelected = Int16.Parse(WatchSelectedInput);

                if (WatchSelected < WatchColection.Count)
                {
                    return WatchSelected;
                }
                else
                {
                    return -1;
                }

            }
            else
            {
                Console.WriteLine("Gi ett tall...");
                return GetUserInput(WatchColection);
            }
        }


    }
}
