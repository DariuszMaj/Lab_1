using System;
using System.Linq;
using System.Collections.Generic;

using System.IO;

namespace Lab_01PO
{
   public class Program
    {
        static void Main(string[] args)
        {
            Ulamek a = new Ulamek(1, 0);
            Ulamek b = new Ulamek(-1, 2);
            Ulamek c = a + b;
            Ulamek d = a - b;
            Ulamek e = a / b;
            Ulamek f = a * b;
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(Ulamek.RoundValueUp(a));
           
        }
    }
    public class Ulamek : IComparable<Ulamek>
    {

        public int CompareTo(Ulamek a)
        {
            var first = ((double)a.licznik / (double)a.mianownik);
            var second = ((double)this.licznik / (double)this.mianownik);
            if (second.Equals(a)) return 0;
            else if (first > second) return 1;
            else return -1;

        }


        //1. PRYWATNE ZMIENNE
        public int licznik { get; }
       
       public int mianownik { get; }



        //KONSTRUKTOR DOMYŚLNY
        public Ulamek()
        {
            this.licznik = 1;
            this.mianownik = 1;
        }

        //KONSTRUKTOR Z DWOMA ARGUMENTAMI
        public Ulamek(int licznik, int mianownik)
        {
            if (mianownik == 0) throw new ArgumentException("Wrong details!");
            else if (licznik == 0)
            {
                licznik = 0;
                mianownik = 0;
            }
            if(licznik<0 && mianownik < 0)
            {
                this.licznik = licznik * (-1);
                this.mianownik = mianownik * (-1);
            }
            else
            {
                this.licznik = licznik;
                this.mianownik = mianownik;
            }
        }

        //KONSTRUKTOR KOPIUJĄCY
        public Ulamek(Ulamek copy)
        {
            licznik = copy.licznik;
            mianownik = copy.mianownik;
        }


        //PRZEŁADOWANIE DODAWANIA
        public static Ulamek operator +(Ulamek a, Ulamek b)

        {

            var c = (a.mianownik) * (b.mianownik);
            var d = (a.licznik) * b.mianownik;
            var e = (b.licznik) * a.mianownik;
            var up = d + e;
            if (up == 0) return new Ulamek(0, c);

            return new Ulamek(up, c);
        }

        //PRZEŁADOWANIE ODEJMOWANIA
        public static Ulamek operator -(Ulamek a, Ulamek b)
        {
            var c = (a.mianownik) * (b.mianownik);
           
            
                var d = (a.licznik) * b.mianownik;
           
                var e = (b.licznik) * a.mianownik;
                var up = d - e;

                if (up == 0) return new Ulamek(0, c);

                return new Ulamek(up, c);
            
        }

        //PRZEŁADOWANIE DZIELENIA
        public static Ulamek operator /(Ulamek a, Ulamek b)
        {
            var up = a.licznik * b.mianownik;
            var down = a.mianownik * b.licznik;
            return new Ulamek(up, down);
        }

        //PRZEŁADOWANIE MNOŻENIA
        public static Ulamek operator *(Ulamek a, Ulamek b)
        {
            var up = a.licznik * b.licznik;
            var down = a.mianownik * b.mianownik;
            return new Ulamek(up, down);
        }
        //METODA ZAOKRĄGLANIE DO GÓRY
        public static int RoundValueUp (Ulamek a)
        {
            return (int)Math.Ceiling((double)a.licznik / (double)a.mianownik);
        }

        //METODA ZAOKRĄGLANIE NA DÓŁ
        public static int RoundValueDown(Ulamek a)
        {
            return (int)Math.Floor((double)a.licznik / (double)a.mianownik);
        }

        //METODA TO STRING
        public override string ToString() => $"Licznik: {licznik} Mianownik: {mianownik}";

        //  public static fraction operator +(fraction a)=>a;
        //    public static fraction operator -(fraction a)=>new fraction(-a.licznik,a.mianownik);



    }

}
