using System;
using System.Windows.Forms;

namespace GuessTheMelody
{
    public partial class EnterName : Form
    {
        public EnterName()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Введите имя!");
                return;
            }
            Program.userName = textBox1.Text;
            this.Close();
        }
    }
}
