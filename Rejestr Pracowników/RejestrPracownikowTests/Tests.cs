using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RejestrPracownikow;

namespace RejestrPracownikowTests
{
    [TestClass]
    public class AdressTest
    {
        [TestMethod]
        public void mainConstuctor()
        {
            Adress a = new Adress("", 0, 0, "");
            Assert.IsNotNull(a);
        }

    }

    [TestClass]
    public class WorkerTest
    {
        [TestMethod]
        public void exp()
        {
            OfficeWorker w = new OfficeWorker("Mateusz", "Szyłejko", 22, 5, new Adress("Bratkowa", 15, 1, "Olsztyn"), 140);
            Assert.AreEqual(5, w.getExp());
        }

        [TestMethod]
        public void age()
        {
            OfficeWorker w = new OfficeWorker("Mateusz", "Szyłejko", 22, 5, new Adress("Bratkowa", 15, 1, "Olsztyn"), 140);
            Assert.AreEqual(22, w.getAge());
        }

        [TestMethod]
        public void uniqueID()
        {
            OfficeWorker w = new OfficeWorker("Mateusz", "Szyłejko", 22, 5, new Adress("Bratkowa", 15, 1, "Olsztyn"), 140);
            PhysicalWorker w2 = new PhysicalWorker("Grzegorz", "Szyłejko", 22, 5, new Adress("Bratkowa", 15, 1, "Olsztyn"), 100);
            Assert.AreNotEqual(w.getId(), w2.getId());
        }
    }

    [TestClass]

    public class TraderTest
    {
        [TestMethod]
        public void efficiency()
        {
            Trader t = new Trader("Mateusz", "Szyłejko", 22, 5, new Adress("Bratkowa", 15, 1, "Olsztyn"), 60, "HIGH");
            Assert.AreEqual(t.getConvertedEff(), 120);
        }

        [TestMethod]
        public void ValueForCorporationByTrader()
        {
            Trader t = new Trader("Mateusz", "Szyłejko", 22, 5, new Adress("Bratkowa", 15, 1, "Olsztyn"), 60, "HIGH");
            Assert.AreEqual(t.getValueOfCorp(), 600);
        }
    }

    [TestClass]

    public class OfficeWorkerTest
    {
        [TestMethod]
        public void IqOutofRange()
        {

            Assert.ThrowsException<System.ArgumentOutOfRangeException>(
                () =>
                {
                    OfficeWorker of = new OfficeWorker("Mateusz", "Szyłejko", 22, 5, new Adress("Bratkowa", 15, 1, "Olsztyn"), 60);
                }
            );
        }

        [TestMethod]
        public void ValueForCorporationByOfficeWorker()
        {
            OfficeWorker of = new OfficeWorker("Mateusz", "Szyłejko", 22, 5, new Adress("Bratkowa", 15, 1, "Olsztyn"), 150);
            Assert.AreEqual(of.getValueOfCorp(), 750);
        }

        [TestMethod]
        public void uniqueID()
        {
            OfficeWorker of = new OfficeWorker("Mateusz", "Szyłejko", 22, 5, new Adress("Bratkowa", 15, 1, "Olsztyn"), 140);
            OfficeWorker of2 = new OfficeWorker("Grzegorz", "Szyłejko", 22, 5, new Adress("Bratkowa", 15, 1, "Olsztyn"), 100);
            Assert.AreNotEqual(of.getIdDesk(), of2.getIdDesk());
        }
    }

    [TestClass]

    public class PhysicalWorkerTest
    {
        [TestMethod]
        public void ValueForCorporationByPhysicalWorker()
        {
            PhysicalWorker phw2 = new PhysicalWorker("Mateusz", "Szyłejko", 22, 5, new Adress("Bratkowa", 15, 1, "Olsztyn"), 100);
            Assert.AreEqual(phw2.getValueOfCorp(), 27,272727272727273);
        }

        [TestMethod]
        public void StrengthOutofRange()
        {

            Assert.ThrowsException < System.ArgumentOutOfRangeException> (
                () =>
                {
                    PhysicalWorker phw = new PhysicalWorker("Mateusz", "Szyłejko", 22, 5, new Adress("Bratkowa", 15, 1, "Olsztyn"), 101);
                }
            );
        }
    }

    [TestClass]

    public class RegisterTest
    {
        [TestMethod]

        public void addWorker()
        {
            Register r = new Register();
            OfficeWorker of = new OfficeWorker("Mateusz", "Szyłejko", 22, 5, new Adress("Bratkowa", 15, 1, "Olsztyn"), 140);
            r.addToRegister(of);
            Assert.AreEqual(1, r.getSize());
        }

        [TestMethod]

        public void addTwoWorker()
        {
            Register r = new Register();
            OfficeWorker of = new OfficeWorker("Mateusz", "Szyłejko", 22, 5, new Adress("Bratkowa", 15, 1, "Olsztyn"), 140);
            OfficeWorker of2 = new OfficeWorker("Grzegorz", "Szyłejko", 22, 5, new Adress("Bratkowa", 15, 1, "Olsztyn"), 100);
            r.addToRegister(of);
            r.addToRegister(of2);
            Assert.AreEqual(2, r.getSize());
        }

        [TestMethod]

        public void deleteWorker()
        {
            Register r = new Register();
            OfficeWorker of = new OfficeWorker("Mateusz", "Szyłejko", 22, 5, new Adress("Bratkowa", 15, 1, "Olsztyn"), 140);
            r.addToRegister(of);
            r.deleteFromRegister(1);
            Assert.AreEqual(1, r.getSize());
        }

        [TestMethod]
        public void workersFromCity()
        {
            Register r = new Register();
            OfficeWorker of = new OfficeWorker("Mateusz", "Szyłejko", 22, 5, new Adress("Bratkowa", 15, 1, "Olsztyn"), 140);
            OfficeWorker of2 = new OfficeWorker("Mateusz", "Szyłejko", 22, 5, new Adress("Bratkowa", 15, 1, "Olsztyn"), 140);
            OfficeWorker of3 = new OfficeWorker("Mateusz", "Szyłejko", 22, 5, new Adress("Bratkowa", 15, 1, "Barczewo"), 140);
            r.addToRegister(of);
            r.addToRegister(of2);
            r.addToRegister(of3);

            List<Worker> workersFromOlsztyn = r.getWorkersFromCity("Olsztyn");

            Assert.AreEqual(2, workersFromOlsztyn.Count);
        }
    }
}
