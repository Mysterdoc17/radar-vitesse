namespace radarVitesse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // affichage d'une confirmation de la prise en compte des données
            MessageBox.Show("bien pris en compte");

            // création d'une instance de la classe connectionDB
            connectionDB connection = new connectionDB("localhost", "radarVitesse", "root", "");

            // envoi des données à la base de données
            string query = "INSERT INTO radarVitesse (id, vitesse, date) VALUES (NULL, " + textBox1.Text + ", NOW())";
            
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // instanciation de la classe de lecture du fichier
            LecteurFichier lf = new LecteurFichier("", "");
            // lecture du fichier
            lf.LireFichier();
            // affichage du contenu du fichier
            textBox1.Text = lf.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // nommer le label

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void image2_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // instanciation de la classe de lecture du fichier
            LecteurFichier lf = new LecteurFichier("", "");
            lf.LireFichier();
            // affichage du contenu du fichier
            textBox2.Text = lf.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // instanciation de la classe de lecture du fichier
            LecteurFichier lf = new LecteurFichier("", "");
            lf.LireFichier();
            // affichage du contenu du fichier
            textBox2.Text = lf.ToString();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            LecteurFichier lf1 = new LecteurFichier("", "");
            lf1.LireFichier();
            // affichage du contenu du fichier
            textBox2.Text = lf1.ToString();
        }
    }
}