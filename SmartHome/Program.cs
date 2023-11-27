using KompHeizung;
using KompMarkisensteuerung;
using KompWetterstation;

namespace SmartHome {
    internal class Program {
        static void Main(string[] args) {
            var wetterstation = new Wetterstation();

            var markistensteuerung = new Markisensteuerung();
            var heizung = new Heizung();

            //wetterstation.RegisterAktor(markistensteuerung);
            //wetterstation.RegisterAktor(heizung);

            wetterstation.WetterEvent += markistensteuerung.ErhalteMesswert;
            wetterstation.WetterEvent += heizung.ErhalteMesswert;

            wetterstation.StartMessung();
        }
    }
}