//using KompWetterstation;

namespace KompHeizung {
    public class Heizung /*: IAktor*/ {
        public void ErhalteMesswert(double temp, bool regen, double wind) {
            Console.WriteLine($"[Heizung] Temperatur: {temp} °C");
        }
    }
}