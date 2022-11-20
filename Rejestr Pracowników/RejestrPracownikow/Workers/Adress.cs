namespace RejestrPracownikow
{
    public class Adress
    {
        private string streetname;
        private int number;
        private int localnumber;
        private string city;

        public Adress(string streetName, int number, int localNumber, string city)
        {
            this.streetname = streetName;
            this.number = number;
            this.localnumber = localNumber;
            this.city = city;
        }
       
        public string getStreetName()
        {
            return this.streetname;
        }

        public int getNumber()
        {
            return this.number;
        }

        public int getLocalNumber()
        {
            return this.localnumber;
        }

        public string getCity()
        {
            return this.city;
        }

        public override string ToString()
        {
            string field = "";

            field += "Street: " + getStreetName();
            field += " Number: " + getNumber();
            field += " Local Number: " + getLocalNumber();
            field += " City: " + getCity();

            return field;
        }
    }
}
