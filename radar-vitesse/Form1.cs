namespace radar_vitesse;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    public void label1(object sender, EventArgs e)
    {
        Label label1 = new Label();
        label1.Text = "Vitesse";
        Controls.Add(label1);
    }

    public void textBox1(object sender, EventArgs e)
    {
        TextBox textBox1 = new TextBox();
        textBox1.Text = "Saisir une vitesse";
        Controls.Add(textBox1);
    }
}
