using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometrischeFormenInterfaces_ConsoleApplication
{
    public interface IAnzeige
    {
        void HierBinIch(string name);

        void EineForm(string form);

        void AllesAnzeigen(string name, string form, int x, int y);
    }
}