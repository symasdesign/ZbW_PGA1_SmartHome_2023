//using KompWetterstation;

namespace KompMarkisensteuerung {
    public class Markisensteuerung /*: IAktor*/ {
        public void ErhalteMesswert(double temp, bool regen, double wind) {
            Console.WriteLine($"[Markisensteuerung] Regen: {(regen ? "ja" : "nein")}, Windgeschwindigkeit: {wind} km/h");
        }
    }
}