using System;
using System.Windows.Forms;

namespace GuessTheMelody
{
    public partial class ChangeLevelForm : Form
    {
        public ChangeLevelForm()
        {
            InitializeComponent();
            var f = new EnterName();
            f.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form f = new MainForm();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void pictureBox4_MouseHover_1(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = GuessTheMelody.Properties.Resources.Назад__Свечение_;
        }

        private void pictureBox4_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = GuessTheMelody.Properties.Resources.Назад;
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = GuessTheMelody.Properties.Resources.легкий__свечение_;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = GuessTheMelody.Properties.Resources.легкий;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = GuessTheMelody.Properties.Resources.Средний__свечение_;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = GuessTheMelody.Properties.Resources.Средний;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = GuessTheMelody.Properties.Resources.Сложный__свечение_;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = GuessTheMelody.Properties.Resources.Сложный;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var f = new Game(10, "Легкий");
            Hide();
            f.ShowDialog();
            Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var f = new Game(15, "Средний");
            Hide();
            f.ShowDialog();
            Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var f = new Game(20, "Сложный");
            Hide();
            f.ShowDialog();
            Show();
        }
    }
}
