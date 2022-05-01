using System;

namespace calculVitesse
{
    class Program
    {
        public static void Main(string[] args) {
            /*
            affichage par défaut
            Console.WriteLine("Bonjour le monde !");
            */

            // demande des differentes valeurs a l'utilisateur et les stocke dans des variables pour l'instanciation de la classe Parametres
            Console.WriteLine("Entrez la distance en km :");
            int distance = int.Parse(Console.ReadLine());

            Console.WriteLine("Entrez le temps de depart en minutes :");
            int temps_depart = int.Parse(Console.ReadLine());

            Console.WriteLine("Entrez le temps d'arrivee en minutes :");
            int temps_arrivee = int.Parse(Console.ReadLine());  // int.Parse() convertit une chaine de caractere en un entier


            // instanciation de la classe Parametres dans la variable param1
            var param1 = new Parametres(distance, temps_depart, temps_arrivee);
            
            // affichage des differentes valeurs de la classe Parametres
            Console.WriteLine(param1.ToString());
            /*
            TODO:
            - script de génération des données de test
            - implémentation de l'import des images
            */
        }
    }
}