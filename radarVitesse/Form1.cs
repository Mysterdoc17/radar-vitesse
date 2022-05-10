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
            // Création d'un titre pour la fenêtre de saisie
            this.Text = "Saisie de la vitesse";
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // reste vide pour l'instant
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // texte du label pour la saisie des infos de l'utilisateur
            this.Text = "test";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // reste vide pour l'instant
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // texte du label pour la saisie des infos de l'utilisateur
            this.Text = "label2";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Text = "label";
        }

        private void image2_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // reste vide pour l'instant
        }
    }
}