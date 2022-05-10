namespace radarVitesse {
    class PixelFormat {
        private int width;
        private int height;

        // Constructeur de la classe PixelFormat
        public PixelFormat(int width, int height) {
            this.width = width;
            this.height = height;
        }
        
        // accesseur de la largeur
        public int getWidth() {
            return this.width;
        }

        // accesseur de la hauteur
        public int getHeight() {
            return this.height;
        }

        //implémentation de la void Format24bppRgb()
        public void Format24bppRgb() {
            // TODO - implementer PixelFormat.Format24bppRgb
            throw new NotImplementedException();
        }
    }
}