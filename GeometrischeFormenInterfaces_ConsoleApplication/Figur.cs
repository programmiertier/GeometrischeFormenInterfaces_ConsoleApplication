using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GeometrischeFormenInterfaces_ConsoleApplication
{
    public class Figur : IAnzeige, IVerschiebbar
    {

        protected KeyValuePair<int, int> mittelpunkt;
        protected double umfang;
        protected double flaeche;
        protected static int x;
        protected static int y;

        public Figur(int x, int y)
        {
            // Console.WriteLine("Figur wird bei {0},{1} erzeugt ",x,y);
            mittelpunkt = new KeyValuePair<int, int>(x, y);
        }

        public void HierBinIch(string name)
        {
            
            WriteLine("Ich bin ein:\t{0}", name);
        }

        public void EineForm(string form)
        {
            
            WriteLine("Meine Form ist:\t{0}", form);
            WriteLine("---");
        }

        public void AllesAnzeigen(string name, string form, int x, int y)
        {
            SetCursorPosition(x, y);
            WriteLine("Name: {0}, Form: {1}", name, form);
        }

        public KeyValuePair<int, int> Mittelpunkt
        {
            get
            {
                return mittelpunkt;
            }

            set
            {
                mittelpunkt = value;
            }
        }

        public double Umfang
        {
            get
            {
                return umfang;
            }

            set
            {
                umfang = value;
            }
        }

        public double Flaeche
        {
            get
            {
                return flaeche;
            }

            set
            {
                flaeche = value;
            }
        }

        public bool AnzeigeFlaechenÜberwachung(int x, int y)
        {
            throw new NotImplementedException();
        }

        public KeyValuePair<int, int> Verschieben(int x_delta, int y_delta)
        {
            SetCursorPosition(this.Mittelpunkt.Key, this.Mittelpunkt.Value);
            WriteLine("                                                  ");
            return new KeyValuePair<int, int>(this.Mittelpunkt.Key + x_delta, this.Mittelpunkt.Value + y_delta);


        }
    }
}
