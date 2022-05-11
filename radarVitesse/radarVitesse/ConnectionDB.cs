namespace radarVitesse {
    class connectionDB {
        // attributs
        private string server = "localhost";
        private string database = "radarVitesse";
        private string user = "root";
        private string password;

        // constructeur
        public connectionDB(string server, string database, string user, string password) {
            this.server = server;
            this.database = database;
            this.user = user;
            this.password = password;
        }

        // accesseurs
        public string GetServer() {
            return this.server;
        }

        public string GetDatabase() {
            return this.database;
        }

        public string GetUser() {
            return this.user;
        }

        public string GetPassword() {
            return this.password;
        }
    }
}