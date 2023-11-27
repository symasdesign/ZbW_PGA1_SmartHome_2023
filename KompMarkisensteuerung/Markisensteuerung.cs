//using KompWetterstation;

namespace KompMarkisensteuerung {
    public class Markisensteuerung /*: IAktor*/ {
        public string ErhalteMesswert(double temp, bool regen, double wind) {
            Console.WriteLine($"[Markisensteuerung] Regen: {(regen ? "ja" : "nein")}, Windgeschwindigkeit: {wind} km/h");

            return "Markisensteuerung OK";
        }
    }
}