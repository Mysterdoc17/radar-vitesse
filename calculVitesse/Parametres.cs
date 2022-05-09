using System;

namespace calculVitesse
{
    class Parametres
    {
        private int distance;
        private int temps_depart;
        private int temps_arrivee;

        public Parametres(int distance, int temps_depart, int temps_arrivee)
        {
            this.distance = distance;
            this.temps_depart = temps_depart;
            this.temps_arrivee = temps_arrivee;
        }

        public int getDistance() {
            return this.distance;
        }

        public int getTempsDepart() {
            return this.temps_depart;
        }
        public int getTempsArrivee()
        {
            return this.temps_arrivee;
        }

        public void diffTemps(int temps_depart, int temps_arrivee)
        {
            int ret = temps_arrivee - temps_depart;
            Console.WriteLine("Le temps de parcours est de : " + ret + " minutes");
        }
        public override string ToString() {
            return "Distance : " + this.distance + " km" + "\n" + "Temps de depart : " + this.temps_depart + " minutes" + "\n" + "Temps d'arrivee : " + this.temps_arrivee + " minutes";
        }
    }
}
