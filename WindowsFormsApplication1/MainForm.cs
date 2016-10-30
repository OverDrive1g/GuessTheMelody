using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication1
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
            playPicBox.BackgroundImage = WindowsFormsApplication1.Properties.Resources.Играть__Свечение_;
        }

        private void playPicBox_MouseLeave(object sender, EventArgs e)
        {
            playPicBox.BackgroundImage = WindowsFormsApplication1.Properties.Resources.Играть;
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
            rulesPicBox.BackgroundImage = WindowsFormsApplication1.Properties.Resources.Правила__Свечение_;
        }

        private void rulesPicBox_MouseLeave(object sender, EventArgs e)
        {
            rulesPicBox.BackgroundImage = WindowsFormsApplication1.Properties.Resources.Правила;
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
            recordsPicBox.BackgroundImage = WindowsFormsApplication1.Properties.Resources.Рекорды__Свечение_;
        }

        private void recordsPicBox_MouseLeave(object sender, EventArgs e)
        {
            recordsPicBox.BackgroundImage = WindowsFormsApplication1.Properties.Resources.Рекорды;
        }

        private void exitPicBox_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void exitPicBox_MouseHover(object sender, EventArgs e)
        {
            exitPicBox.BackgroundImage = WindowsFormsApplication1.Properties.Resources.EXIT;
        }

        private void exitPicBox_MouseLeave(object sender, EventArgs e)
        {
            exitPicBox.BackgroundImage = WindowsFormsApplication1.Properties.Resources.Выход;
        }
    }
}
