namespace radarVitesse
{
    class Bitmap {
        private int width;
        private int height;
        private PixelFormat pixelFormat;

        // Constructeur de la classe Bitmap
        public Bitmap(int width, int height, PixelFormat pixelFormat) {
            this.width = width;
            this.height = height;
            this.pixelFormat = pixelFormat;
        }
        
        public int getWidth() {
            return this.width;
        }
        
        public int getHeight() {
            return this.height;
        }

        public PixelFormat getPixelFormat() {
            return this.pixelFormat;
        }

        public Color GetPixel(int x, int y) {
            return new Color();
        }
    }
}