using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace RejestrPracownikow
{
    public class PhysicalWorker : Worker
    {
        private int strength;

        public PhysicalWorker(string name, string surname, int age, int exp, Adress adress, int strength) : base(name, surname, age, exp, adress) 
        {
            if (strength < 1 || strength > 100)
            {
                throw new System.ArgumentOutOfRangeException("Strength is out of range");
            }

            this.strength = strength;
        }

        public int getStrenght()
        {
            return this.strength;
        }

        public override double getValueOfCorp()
        {
            return ((double)this.getExp()) * ((double)this.getStrenght()) / ((double)this.getAge());
        }

        public override string ToString()
        {
            string field = base.ToString();
            field += " Strength: " + this.getStrenght();
            field += " Value for Corporation: " + this.getValueOfCorp();
            return field;
        }
    }
}
