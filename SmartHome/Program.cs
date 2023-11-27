using KompHeizung;
using KompMarkisensteuerung;
using KompWetterstation;

namespace SmartHome {
    internal class Program {
        static void Main(string[] args) {
            var wetterstation = new Wetterstation();

            var markistensteuerung = new Markisensteuerung();
            var heizung1 = new Heizung("H1");
            var heizung2 = new Heizung("H2");

            //wetterstation.RegisterAktor(markistensteuerung);
            //wetterstation.RegisterAktor(heizung);

            wetterstation.WetterEvent += markistensteuerung.ErhalteMesswert;
            //wetterstation.WetterEvent += new WetterObserver(heizung.ErhalteMesswert);
            wetterstation.WetterEvent += heizung1.ErhalteMesswert;
            wetterstation.WetterEvent += heizung2.ErhalteMesswert;

            wetterstation.StartMessung();
        }
    }
}