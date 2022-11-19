namespace RejestrPracownikow
{
    public abstract class Worker
    {
        public int Id { get; }
        public string? Name { get; }
        public string? Subname { get; }
        public int Age { get; }
        public int Exp { get; }
        public Adress? Adress;

        //int id = 0;

        public Worker(int id, string? name, string? subname, int age, int exp, Adress? adress)
        {
            Id = id;
            Name = name;
            Subname = subname;
            Age = age;
            Exp = exp;
            Adress = adress;
        }
    }
}