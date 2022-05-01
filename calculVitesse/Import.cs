using System;

namespace calculVitesse
{
    class import
    {
        // script d'import d'une image
        public static void importImage() {
            Console.WriteLine("Entrez le chemin de l'image :");
            string chemin = Console.ReadLine();
            Console.WriteLine("Entrez le nom de l'image :");
            string nom = Console.ReadLine();
            Console.WriteLine("Entrez le type de l'image :");
            string type = Console.ReadLine();
            Console.WriteLine("Entrez la taille de l'image :");
            string taille = Console.ReadLine();
        }
    }
}