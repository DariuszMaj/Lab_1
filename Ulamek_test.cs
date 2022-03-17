using Lab_01PO;

using NUnit.Framework;

namespace Ulamki_TEST
{
    public class Ulamek_test
    {
        
        //DODAWANIE

        [Test]

        public void Dodawanie_Liczb()
        {
            var a = new Ulamek(3, 2);
            var b = new Ulamek(5, 3);
            var c = a + b;
            Assert.AreEqual(19, c.licznik);
            Assert.AreEqual(6, c.mianownik);
        }
        [Test]

        public void Dodawanie_Liczby_Z_Ujemnym_Licznikiem()
        {
            var a = new Ulamek(1, 2);
            var b = new Ulamek(-1, 2);
            var c = a + b;   
            Assert.AreEqual(0,c.licznik);
            Assert.AreEqual(0,c.mianownik);
        }

         [Test]

        public void Dodawanie_Liczby_Z_Ujemnym_Licznikiem_Mianownikiem()
        {
            var a = new Ulamek(1, 8);
            var b = new Ulamek(-1, -32);
            var c = a + b;   
            Assert.AreEqual(40,c.licznik);
            Assert.AreEqual(256,c.mianownik);
        }
        [Test]

        public void Dodawanie_Liczb_ujemnych()
        {
            var a = new Ulamek(-11, -22);
            var b = new Ulamek(-169, -1232);
            var c = a + b;
            Assert.AreEqual(17270, c.licznik);
            Assert.AreEqual(27104, c.mianownik);
        }




        //ODEJMOWANIE

        [Test]

        public void Odejmowanie_Liczb()
        {
            var a = new Ulamek(62, 43);
            var b = new Ulamek(3, 57);
            var c = a - b;
            Assert.AreEqual(3405, c.licznik);
            Assert.AreEqual(2451, c.mianownik);
        }

        [Test]
        public void Odejmowanie_Liczby_Z_Ujemnym_Licznikiem()
        {
            var a = new Ulamek(1, 2);
            var b = new Ulamek(-6, 4);
            var c = a - b;
            Assert.AreEqual(16, c.licznik);
            Assert.AreEqual(8, c.mianownik);
        }

        [Test]

        public void Odejmowanie_Liczby_Z_Ujemnym_Licznikiem_Mianownikiem()
        {
            var a = new Ulamek(24, 18);
            var b = new Ulamek(-37, -72);
            var c = a - b;
            Assert.AreEqual(1062, c.licznik);
            Assert.AreEqual(1296, c.mianownik);
        }
        [Test]

        public void Odejmowanie_Liczb_ujemnych()
        {
            var a = new Ulamek(-11, -22);
            var b = new Ulamek(-169, -1232);
            var c = a - b;
            Assert.AreEqual(9834, c.licznik);
            Assert.AreEqual(27104, c.mianownik);
        }




        //DZIELENIE


        [Test]
        public void Dzielenie_Liczb()
        {
            var a = new Ulamek(1, 64);
            var b = new Ulamek(2, 128);
            var c = a / b;
            Assert.AreEqual(128, c.licznik);
            Assert.AreEqual(128, c.mianownik);
        }

        [Test]
        public void Mnozenie_Liczb()
        {
            var a = new Ulamek(64, 256);
            var b = new Ulamek(1024, 512);
            var c = a * b;
            Assert.AreEqual(65536, c.licznik);
            Assert.AreEqual(131072, c.mianownik);
        }





    }
}