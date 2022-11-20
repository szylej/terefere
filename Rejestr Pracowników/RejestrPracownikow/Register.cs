using System.Collections.Generic;

namespace RejestrPracownikow
{
    public class Register
    {
        private List<Worker> workerslist = new List<Worker>();

        public List<Worker> Workerslist 
        {
            get => workerslist;
            set => workerslist = value;
        }

        public void addToRegister(Worker worker)
        {
            Workerslist.Add(worker);
        }

        public void deleteFromRegister(int id)
        {
            foreach (var record in Workerslist.ToList())
            {
                if (record.getId() == id)
                {
                    Workerslist.Remove(Workerslist.Single(x => x.getId() == id));
                }
            }
        }

        public int getSize()
        {
            return workerslist.Count;
        }

        public List<Worker> orderByExp()
        {
            List<Worker> SortedWorkerList = Workerslist.OrderByDescending(worker => worker.getExp()).ToList();
            return SortedWorkerList;
        }

        public List<Worker> orderByAge()
        {
            List<Worker> SortedWorkerList = Workerslist.OrderBy(worker => worker.getAge()).ToList();
            return SortedWorkerList;
        }

        public List<Worker> orderBySurname()
        {
            List<Worker> SortedWorkerList = Workerslist.OrderBy(worker => worker.getSurname()).ToList();
            return SortedWorkerList;
        }

        public override string ToString()
        {
            string field = "";

            foreach (Worker worker in workerslist)
            {
                field += worker.ToString();
                field += "\n";
            }
            return field;
        }

        public List<Worker> getWorkersFromCity(string city)
        {
            return this.workerslist.FindAll(worker => worker.getAdress().getCity() == city);
        }
     }
}