using System.ComponentModel.DataAnnotations;
namespace RejestrPracownikow
{
    public class PhysicalWorker : Worker
    {
        private uint _strength;
        public uint Strength
        {
            get { return _strength; }
            set
            {
                value = Math.Min(value, 100u);
                value = Math.Max(value, 1u);
                _strength = value;
            }
        }

        public PhysicalWorker(int id, string name, string subname, int age, int exp, Adress adress, unit strength) : base(id, name, subname, age, exp, adress) 
        {
            this.Strength = strength;
        }
    }
}
