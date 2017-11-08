using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GeometrischeFormenInterfaces_ConsoleApplication
{
    public class Figur : IAnzeige
    {
        protected static int x;
        protected static int y;

        

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

        public void Hier(int x, int y)
        {
            SetCursorPosition(x, y);
            WriteLine();
        }
    }
}
