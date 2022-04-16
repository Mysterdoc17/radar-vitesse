namespace radar_vitesse;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    
    private void label_vitesse()
    {
        Label label1 = new Label();;
        label1.Text = "Vitesse";
        Controls.Add(label1);
    }

    // definition de la textbox pour la vitesse
    private void textBox_vitesse(object sender, EventArgs e)
    {
        TextBox textBox1 = new TextBox();
        textBox1.Text = "Saisir une vitesse";
        Controls.Add(textBox1);
    }

    // definition du bouton de validation
    private void valider(object sender, EventArgs e)
    {
        Button button1 = new Button();
        button1.Text = "Valider";
        Controls.Add(button1);
    }
    
    // definition du bouton quitter
    private void quitter(object sender, EventArgs e)
    {
        Button button2 = new Button();
        button2.Text = "Quitter";
        Controls.Add(button2);
    }

    public getLabelVitesse()
    {
        label_vitesse();
    }
}
