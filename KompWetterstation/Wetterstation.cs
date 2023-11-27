//using KompHeizung;
//using KompMarkisensteuerung;

namespace KompWetterstation {

    public delegate void WetterObserver(double temp, bool regen, double wind);

    public class Wetterstation {
        private Random random;
        //private Heizung heizung;
        //private Markisensteuerung markisensteuerung;

        //private List<IAktor> aktoren = new List<IAktor>();

        public Wetterstation() {
            this.random = new Random(10);
            //this.heizung = new Heizung();
            //this.markisensteuerung = new Markisensteuerung();
        }

        public WetterObserver WetterEvent;

        //public void RegisterAktor(IAktor aktor) {
        //    this.aktoren.Add(aktor);
        //}
        public void StartMessung() {
            while (true) {

                var rand = this.random.NextDouble();

                var regen = rand > 0.5;

                var temp = this.random.Next(-25, 35);
                var wind = Math.Round(120 * rand);

                this.SendeMesswert(temp, regen, wind);
                Thread.Sleep(5000);
            }
        }

        private void SendeMesswert(double temp, bool regen, double wind) {
            //this.heizung.ErhalteMesswert(temp);
            //this.markisensteuerung.ErhalteMesswert(regen, wind);

            //foreach(var aktor in this.aktoren) {
            //    aktor.ErhalteMesswert(temp, regen, wind);
            //}

            if (this.WetterEvent != null) {
                this.WetterEvent(temp, regen, wind);
            }
        }
    }
}