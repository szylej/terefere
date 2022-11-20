namespace RejestrPracownikow
{
    public class OfficeWorker : Worker
    { 
        private int IdDesk;
        static private int nextIdDesk;
        private int iq;

        public OfficeWorker(string name, string surname, int age, int exp, Adress adress, int iq) : base(name, surname, age, exp, adress)
        {
            if (iq < 70 || iq > 150)
            {
                throw new System.ArgumentOutOfRangeException("Iq is out of range");
            }

            this.IdDesk = nextIdDesk++;
            this.iq = iq;
        }

        public int getIdDesk()
        {
            return this.IdDesk;
        }

        public int getIq()
        {
            return this.iq;
        }

        public override double getValueOfCorp()
        {
            return this.getExp() * this.getIq();
        }

        public override string ToString()
        {
            string field = base.ToString();
            field += " Desk ID: " + getIdDesk();
            field += " IQ: " + getIq();
            field += " Value for Corporation: " + this.getValueOfCorp();
            return field;
        }
    }
}