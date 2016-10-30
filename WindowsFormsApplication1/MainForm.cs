using System;
using System.Windows.Forms;

namespace GuessTheMelody
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void playPicBox_Click(object sender, EventArgs e)
        {
            var f = new ChangeLevelForm();
            Hide();
            f.ShowDialog();
            Show();
        }

        private void playPicBox_MouseHover(object sender, EventArgs e)
        {
            playPicBox.BackgroundImage = GuessTheMelody.Properties.Resources.Играть__Свечение_;
        }

        private void playPicBox_MouseLeave(object sender, EventArgs e)
        {
            playPicBox.BackgroundImage = GuessTheMelody.Properties.Resources.Играть;
        }

        private void rulesPicBox_Click(object sender, EventArgs e)
        {
            var f = new RulesForm();
            Hide();
            f.ShowDialog();
            Show();
        }

        private void rulesPicBox_MouseHover(object sender, EventArgs e)
        {
            rulesPicBox.BackgroundImage = GuessTheMelody.Properties.Resources.Правила__Свечение_;
        }

        private void rulesPicBox_MouseLeave(object sender, EventArgs e)
        {
            rulesPicBox.BackgroundImage = GuessTheMelody.Properties.Resources.Правила;
        }

        private void recordsPicBox_Click(object sender, EventArgs e)
        {
            var f = new RecordsForm();
            Hide();
            f.ShowDialog();
            Show();
        }

        private void recordsPicBox_MouseHover(object sender, EventArgs e)
        {
            recordsPicBox.BackgroundImage = GuessTheMelody.Properties.Resources.Рекорды__Свечение_;
        }

        private void recordsPicBox_MouseLeave(object sender, EventArgs e)
        {
            recordsPicBox.BackgroundImage = GuessTheMelody.Properties.Resources.Рекорды;
        }

        private void exitPicBox_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void exitPicBox_MouseHover(object sender, EventArgs e)
        {
            exitPicBox.BackgroundImage = GuessTheMelody.Properties.Resources.EXIT;
        }

        private void exitPicBox_MouseLeave(object sender, EventArgs e)
        {
            exitPicBox.BackgroundImage = GuessTheMelody.Properties.Resources.Выход;
        }
    }
}
