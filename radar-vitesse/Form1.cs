namespace radar_vitesse;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    
    private void label_vitesse()
    {
        Label label1 = new Label();
        label1.Text = "Vitesse";
        Controls.Add(label1);
    }
    public void GetLabelVitesse()
    {
        Label label1 = new Label();
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
    public void GetTextBoxVitesse()
    {
        TextBox textBox1 = new TextBox();
        textBox1.Text = "Saisir une vitesse";
        Controls.Add(textBox1);
    }
    // definition du bouton de validation
    private void btn_valider(object sender, EventArgs e)
    {
        Button button1 = new Button();
        button1.Text = "Valider";
        button1.Size = new Size(105, 30);
        Controls.Add(button1);
    }
    
    // definition du bouton quitter
    private void btn_quitter(object sender, EventArgs e)
    {
        Button button2 = new Button();
        button2.Text = "Quitter";
        button2.Size = new Size(105, 30);
        Controls.Add(button2);
    }

}
