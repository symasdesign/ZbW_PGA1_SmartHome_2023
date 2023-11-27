//using KompWetterstation;

namespace KompHeizung {
    public class Heizung /*: IAktor*/ {

        private string name;
        public Heizung(string name) {
            this.name = name;
        }
        public string ErhalteMesswert(double temp, bool raining, double wind) {
            Console.WriteLine($"[Heizung {name}] Temperatur: {temp} °C");

            return "Heizung OK";
        }
    }
}