using System.ComponentModel.DataAnnotations;
namespace RejestrPracownikow
{
    public class Trader : Worker
    {
        //public Efficiency efficiency;
        private uint _provision;
        private string _efficiency;
        public uint Provision
        {
            get { return _provision; }
            set
            {
                value = Math.Min(value, 100u);
                value = Math.Max(value, 0u);
                _provision = value;
            }
        }

        public string Efficiency
        {
            get { return _efficiency; }
            set
            {
                if (value == "NISKA" || value == "SREDNIA" || value == "WYSOKA")
                {
                    _efficiency = value;
                }
                else
                {
                    throw new InvalidOperationException("Error - wrong efficiency type");
                }
            }
        }

        public Trader(int id, string name, string subname, int age, int exp, Adress adress, uint provision, string efficiency) : base(id, name, subname, age, exp, adress)
        {
            this.Provision = provision;
            this.Efficiency = efficiency;
        }
    }
}