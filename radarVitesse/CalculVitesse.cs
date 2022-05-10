

namespace radarVitesse
{
    class CalculVitesse {
        public static void calculVitesse(int temps_depart, int temps_arrivee) {
            /*
                - Calcul de la vitesse en km/h
                - récupération des données de temps avec les saisies utilisateur
                - analyse de la différence des photos
                - affichage de la vitesse
            */
            int vitesse = 0;
            double vitesseKmH = vitesse * 3.6;
            int temps_difference = temps_arrivee - temps_depart;
            // analyse de la différence des photos
            if (temps_difference < 0) {
                MessageBox.Show("Les saisies ne sont pas correctes");
            }
            else {
                /* calcul automatique de la vitesse
                vitesse = temps_difference / 1000;
                vitesseKmH = vitesse * 3.6;
                */
                
                List<string> fileNames = new List<string> { "Input1.png", "Input2.png" };
                
                // récupération des données de temps avec les saisies utilisateur
                int temps_depart_saisie = temps_depart;
                int temps_arrivee_saisie = temps_arrivee;

                // analyse de la différence des photos
                int temps_difference_saisie = temps_arrivee_saisie - temps_depart_saisie;

                // affichage de la vitesse
                MessageBox.Show("Votre vitesse est de " + vitesseKmH + " km/h");

            }    
        }
        public static void pushBase() {
            // instanciation d'une connexion à la base de données
            OleDBConnection conn = new OleDBConnection();

            // création d'une commande pour une entrée dans la base
            OleDBCommand cmd1 = new OleDBCommand('INSERT INTO ... VALUES(\'valeur1\', \'valeur2\' ...');
        }
    }
}