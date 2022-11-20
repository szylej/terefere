using System.ComponentModel.DataAnnotations;
namespace RejestrPracownikow
{
    public class Trader : Worker
    {

        private double provision;
        private string efficiency;

        public Trader(string name, string surname, int age, int exp, Adress adress, double provision, string efficiency) : base(name, surname, age, exp, adress)
        {
            this.provision = provision / 100;
            this.efficiency = efficiency;
        }

        public int EfficiencyConverter(string efficiency)
        {
            int result = 0;

            if (efficiency == "LOW")
            {
                result = 60;
            }
            else if (efficiency == "MEDIUM")
            {
                result = 90;
            }
            else if (efficiency == "HIGH")
            {
                result = 120;
            }
            
            return result;
        }

        public int getConvertedEff()
        {
            int convertedff = EfficiencyConverter(efficiency);
            
            return convertedff;
        }

        public double getProvision()
        {
            return this.provision;
        }

        public string getEfficiency()
        {
            return this.efficiency;
        }

        public override double getValueOfCorp()
        {
            return this.getExp() * this.getConvertedEff();
        }

        public override string ToString()
        {
            string field = base.ToString();
            field += " Provision: " + getProvision();
            field += " Efficiency: " + getEfficiency();
            field += " Value for Corporation: " + this.getValueOfCorp();
            return field;
        }
    }
}