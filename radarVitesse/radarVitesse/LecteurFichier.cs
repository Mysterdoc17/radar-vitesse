namespace radarVitesse {
    class LecteurFichier {
        // attributs
        private string nomFichier;
        private string contenuFichier;
        // constructeur
        public LecteurFichier(string nomFichier, string contenuFichier) {
            this.nomFichier = nomFichier;
            this.contenuFichier = contenuFichier;
        }
        // méthodes
        public void LireFichier() {
            // ouverture du fichier
            StreamReader sr = new StreamReader(nomFichier);
            // lecture du fichier
            contenuFichier = sr.ReadToEnd();
            // fermeture du fichier
            sr.Close();
        }
        
        // accesseurs
        public string GetNomFichier() {
            return this.nomFichier;
        }

        public string GetContenuFichier() {
            return this.contenuFichier;
        }
        // méthode ToString()
        public override string ToString() {
            return contenuFichier;
        }
    }
}