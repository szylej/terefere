namespace RejestrPracownikow
{
    public abstract class Worker
    {

        private int id;
        private string name;
        private string surname;
        private int age;
        private int exp;
        private Adress adress;

        static private int nextId = 0;

        public Worker(string name, string surname, int age, int exp, Adress adress)
        {
            this.id = nextId++;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.exp = exp;
            this.adress = adress;
        }

        public int getId()
        {
            return this.id;
        }

        public string getName()
        {
            return this.name;
        }

        public string getSurname()
        {
            return this.surname;
        }

        public int getAge()
        {
            return this.age;
        }

        public int getExp()
        {
            return this.exp;
        }

        public Adress getAdress()
        {
            return this.adress;
        }

        public abstract double getValueOfCorp();

        public override string ToString()
        {

            string field = "";
            field += "Name: " + getName();
            field += " Surname: " + getSurname();
            field += " Age: " + getAge();
            field += " Expierence: " + getExp();
            field += " Adress: " + getAdress();
            field += " Value of Corporation " + getValueOfCorp();

            return field;
        }
    }   
}