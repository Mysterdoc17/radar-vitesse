using System.Collections.Generic;  
using System.IO;  
using System.Threading.Tasks;

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
        }
        // instanciation de src1
        Bitmap src1 = new Bitmap(int x, int y, PixelFormat pixelFormat);
        public static Bitmap Diff(Bitmap src1, Bitmap src2, int x1, int y1, int x2, int y2, int width, int height){
            Bitmap bmp = new Bitmap(int x, int y);

            Bitmap diffBM = new Bitmap(width, height, PixelFormat.Format24bppRgb);

            for (int y = 0; y < height; y++) {
                for (int x = 0; x < width; x++) {
                    //Obtention des deux couleurs du pixel
                    Color col1 = src1.GetPixel(x1 + x, y1 + y);
                    Color col2 = src2.GetPixel(x2 + x, y2 + y);

                    // Obtention de la différence RVB
                    int r = 0, g = 0, b = 0;
                    r = Math.Abs(col1.R - col2.R);
                    g = Math.Abs(col1.G - col2.G);
                    b = Math.Abs(col1.B - col2.B);

                    // Inversion de la moyenne des différences
                    int dif = 255 - ((r+g+b) / 3);

                    // Création d'une nouvelle couleur RVB en niveaux de gris
                    Color newcol = Color.FromArgb(dif, dif, dif);

                    //diffBM.SetPixel(x, y, newcol);
                }
            }

            //return diffBM;
        }
    }
}