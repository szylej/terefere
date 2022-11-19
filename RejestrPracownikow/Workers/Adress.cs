namespace RejestrPracownikow
{
    public class Adress
    {
        public string? StreetName { get; }
        public int Number { get; }
        public int LocalNumber { get; }
        public string? City { get; }

        public Adress(string? streetName, int number, int localNumber, string? city)
        {
            StreetName = streetName;
            Number = number;
            LocalNumber = localNumber;
            City = city;
        }
    }
}
