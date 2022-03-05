using System;

namespace firstapp
{
    class Program
    {
        static void Main(string[] args)
        {

            Ulamek a = new Ulamek();
            Ulamek b = new Ulamek(1, 8);
            Ulamek c=a + b;
            Console.WriteLine(c);
            Console.WriteLine(b.ToString());

        }
    }

  
    
  


    class Ulamek 
    {
        




    private int licznik;
        private int mianownik;

        public Ulamek()
        {
            this.licznik = 1;
            this.mianownik = 1;
        }


        public Ulamek(int licznik, int mianownik)
        {
            this.licznik = licznik;
            this.mianownik = mianownik;
        }
        public Ulamek(Ulamek copy)
        {

            licznik = copy.licznik;
            mianownik = copy.mianownik;

        }
        public Ulamek()
        {

        }

        public override string ToString() => $"Licznik: {licznik} Mianownik: {mianownik}";


    }

  

    
    
}
