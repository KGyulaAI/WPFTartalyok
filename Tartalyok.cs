using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTartalyok
{
    public class Tartaly
    {
        //todo OK 1.feladat (4p) Az osztály adattagjai a következők: (Minden adattag legyen rejtett!)
        //
        //	nev – karakterlánc(a tartály neve)
        //	a, b, c – int típusú(cm-ben a tartály élhosszai)
        //	aktLiter – double típusú(a tartályban lévő aktuális mennyiség literben)
        private string nev;
        private int a, b, c;
        private double aktLiter;

        //todo 2. feladat (6p) Hozzon létre egy konstruktort, amely 4 paraméterrel rendelkezik(tartály neve és az élek hossza). Ezeket az értékeket adja át a fenti rejtett attribútumoknak.Az aktLiter pedig 0-ra állítja.

        public Tartaly(string nev, int a, int b, int c)
        {
            this.nev = nev;
            this.a = a;
            this.b = b;
            this.c = c;
            aktLiter = 0;
        }
        //todo 3. feladat (3p) Fejezze be az elkezdett konstruktort! Ez a konstruktor egy 10x10x10 cm3 kocka alakú üres tartályt hoz létre és a paraméterként kapott nevet adja neki.

        public Tartaly(String nev)
        {
            this.nev = nev;
            a = 10;
            b = 10;
            c = 10;
            aktLiter = 0;
        }


        //todo 4.feladat (4p) Fejezze be az elkezdett jellemző(property) készítését.Adja vissza a tartály cm3-ban mért térfogatát.

        public double Terfogat
        {
            get { return a * b * c; }
        }

        //todo 5.feladat (2x3p) Készítsen visszatérési érték és paraméter nélküli metódusokat DuplazMeretet és TeljesLeengedes néven.Az DuplazMeretet duplázza a tartály térfogatát valamelyik él értékének változtatásával.A TeljesLeengedes pedig kiüríti a tartályt.

        public void DuplazMeretet()
        {
            a *= 2;
        }

        public void TeljesLeengedes()
        {
            aktLiter = 0;
        }

        //todo 6.feladat (4p) Készítsen Toltottseg néven double típusú tulajdonságot(property). A tulajdonság visszaadja, hogy %-osan milyen szinten van tele a tartály.

        public double Toltottseg
        {
            get => (aktLiter * 1000 / Terfogat) * 100;
        }
        public string Nev { get => nev; }
        public int aEl { get => a; }
        public int bEl { get => b; }
        public int cEl { get => c; }
        public double AktLiter { get => aktLiter; }

        //todo 7.feladat (6p) Készítsen Tolt néven egyparaméteres visszatéréi érték nélküli metódust.A double paraméterben kapott literrel növeli a tartályban lévő mennyiséget.Amennyiben ez a mennyiség nem fér a tartályba, írjon ki hibaüzenetet és ne hajtsa végre a töltést!

        public void Tolt(double mennyit)
        {

            if (Terfogat / 1000 < aktLiter + mennyit)
            {
                //todo Ez nem szép! Helyette kivételt kellene dobni!
                throw new OverflowException();
            }
            aktLiter += mennyit;
        }

        public string Info()
        {
            return string.Format("{0}: {1} cm3 = ({6} liter), töltöttsége: {2}%, ({7} liter), méretei: {3}x{4}x{5} cm"
                , nev
                , Terfogat
                , Toltottseg
                , a
                , b
                , c
                , Terfogat / 1000
                , aktLiter
                );
        }
    }
}
