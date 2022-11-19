namespace RejestrPracownikow
{
    public class OfficeWorker : Worker
    { 
        public int IdDesk { get; }
        private uint _iq;
        public uint Iq
        {
            get { return _iq; }
            set
            {
                value = Math.Min(value, 150u);
                value = Math.Max(value, 70u);
                _iq = value;
            }
        }

        public OfficeWorker(int id, string name, string subname, int age, int exp, Adress adress, int id_desk, uint intelect) : base(id, name, subname, age, exp, adress)
        {
            this.IdDesk = id_desk;
            this.Iq = intelect;
        }
    }
}