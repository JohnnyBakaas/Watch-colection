namespace Objektifisering.Models
{
    public class Watch
    {
        public string Brand;
        public string Name;
        public string Movement;
        public List<string>? Complications;
        public int Year;
        public string Strap;


        public Watch(string name, string brand, string movement, int year, string strap, List<string> complications)
        {
            Name = name;
            Brand = brand;
            Strap = strap;
            Movement = movement;
            Year = year;
            Complications = complications;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Merke: " + Brand);
            Console.WriteLine("Navn: " + Name);
            Console.WriteLine("Mekanisme: " + Movement);
            Console.WriteLine("Komplikasjoner: " + Complications[0]);
            PrintComplications();
            Console.WriteLine("Produser: " + Year);
            Console.WriteLine("Reim: " + Strap);
        }

        private void PrintComplications()
        {
            string offset = "";

            for (int i = 0; i < "Komplikasjoner: ".Length; i++)
            {
                offset += " ";
            }

            int fjusk = 0;
            foreach (string Complication in Complications)
            {
                if (fjusk == 0) { }
                else
                {
                    Console.WriteLine(offset + Complication);
                }
                fjusk++;
            }


        }


    }
}
