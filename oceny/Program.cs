using System;

namespace oceny
{

    class Cd
    {
        public string tytul, nazwiskowykonawca, rok_wydania, nazwa_wydawcy;
        public int cena;



        Utwor[] utwory = new Utwor[25];
        public Cd(string tyt, string wyk, string rokw, string nw, int c )
        {

            tytul = tyt;
            nazwiskowykonawca = wyk;
            rok_wydania = rokw;
            nazwa_wydawcy = nw;
            cena = c;
            
        }


        public void Tworzenieutworow(string t, string w, string cz)
        {
            for (int i = 0; i < utwory.Length; i++)
            {
                utwory[i] = new Utwor(t, w, cz);
            }
        }


        public void Wys()
        {
            for (int i = 0; i < utwory.Length; i++)
            {
                Console.WriteLine(utwory[i].tytul + utwory[i].wykonawca + utwory[i].czastrwania);
            }
        }
    }

    class Utwor
    {
       public string tytul, wykonawca, czastrwania;

        public Utwor(string x, string y, string z)
        {
            tytul = x;
            wykonawca = y;
            czastrwania = z;
        }
    }


class KOLEKCJA_PLYT
    {
       public Cd[] plyty = new Cd[10];

        public void przypisywaniePlyt(Cd plyta)
        {
            for (int i = 0; i < plyty.Length; i++)
            {
            plyty[i] = plyta;

            }
        }

        public void wyswietlanieKolekcji()
        {
            for (int i = 0; i < plyty.Length; i++)
            {
                Console.WriteLine($"Tytul: {plyty[i].tytul},  Wykonawca: {plyty[i].nazwiskowykonawca}, Rok wydania: {plyty[i].rok_wydania}, Cena: {plyty[i].cena}, Nazwa wydawcy: {plyty[i].nazwa_wydawcy}");

            }

        }
    
    }


    class Program
    {
        static void Main(string[] args)
        {

            Cd plyta = new Cd("gang", "maciek44", "2003","lejbel",33);
            plyta.Tworzenieutworow("intro ", "maciek44 ", " 4:20");
            plyta.Wys();
            KOLEKCJA_PLYT kolekcja = new KOLEKCJA_PLYT();
            kolekcja.przypisywaniePlyt(plyta);

            kolekcja.wyswietlanieKolekcji();

        }

    }
}
