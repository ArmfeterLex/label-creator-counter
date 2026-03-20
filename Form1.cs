using System;
using System.Drawing;
using System.Windows.Forms;

namespace proj15
{
    public partial class Form1 : Form
    {
        private int smallLabels = 0;
        private int bigLabels = 0;

        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
                return;

            if (int.TryParse(textBox2.Text, out int x) && int.TryParse(textBox3.Text, out int y) &&
                int.TryParse(textBox4.Text, out int size))
            {
                Label label = new Label();
                label.Text = textBox1.Text;
                label.Location = new Point(x, y);
                label.Size = new Size(size, size);
                label.BorderStyle = BorderStyle.FixedSingle;
                this.Controls.Add(label);

                if (size < 50)
                    smallLabels++;
                else
                    bigLabels++;

                this.Text = $"Маленьких: {smallLabels}  Больших: {bigLabels}";
            }
        }
    }
}