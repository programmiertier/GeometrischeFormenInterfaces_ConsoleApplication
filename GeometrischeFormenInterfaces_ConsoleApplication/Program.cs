using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GeometrischeFormenInterfaces_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Dreieck drei = new Dreieck();
            drei.AllesAnzeigen("Dreieck", "drei Ecken", 0, 0);
            // drei.HierBinIch("Dreieck");
            // drei.EineForm("ich habe drei Ecken, mein Hut der hat...");

            Ellipse elli = new Ellipse();
            elli.AllesAnzeigen("Ellipse", "rund ohne Ecken", 7, 2);
            // elli.HierBinIch("Ellipse");
            // elli.EineForm("ich bin rundlich, ein bisschen gequetscht");

            Kreis rundeRundi = new Kreis();
            rundeRundi.AllesAnzeigen("Kreis", "rund", 5, 4);
            // rundeRundi.HierBinIch("Kreis");
            // rundeRundi.EineForm("ich bin perfekt rund, komplett ohne Ecken");

            Quadrat quadratischPraktisch = new Quadrat();
            rundeRundi.AllesAnzeigen("Quadrat", "vier Ecken", 10, 8);
            // quadratischPraktisch.HierBinIch("Quadrat");
            // quadratischPraktisch.EineForm("ich habe vier Ecken, gleichmäßig, ich könnte ein Würfel sein");

            Rechteck rechtUndEckig = new Rechteck();
            rechtUndEckig.AllesAnzeigen("Rechteck", "vier Ecken, je zwei gleich lange Seiten", 20, 11);
            // rechtUndEckig.HierBinIch("Rechteck");
            // rechtUndEckig.EineForm("fast wie das Quadrat, nur mit je zwei gleichlangen Seiten");

            Trapez komischerKeks = new Trapez();
            komischerKeks.AllesAnzeigen("Trapez", "vier Ecken, verschobenes Rechteck", 25, 13);
            // komischerKeks.HierBinIch("Trapez");
            // komischerKeks.EineForm("Ein bisschen verschobenes Rechteck... ned so genau schauen, bitte");
            Kreis neuerKreis = new Kreis();
            neuerKreis.AllesAnzeigen("Kreis", "rund", 5, 7);
            ReadLine();
        }
    }
}
