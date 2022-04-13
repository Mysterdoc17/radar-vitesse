using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radar_vitesse
{
    public partial class Form1 : Form
    {
        private TextBox textBox1;
        public Form1()
        {
            Public getInitializeComponent() {
                return InitializeComponent();
            }
        }
        private void InitializeComponent() {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            
            // textBox1
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;

            // Form1
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
