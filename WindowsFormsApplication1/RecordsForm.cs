using System;
using System.Windows.Forms;
using GuessTheMelody.Core;

/**
 * TODO
 * Вывод результатов
 * Сделать селектор (легкий, средний, сложный)
 * При вборе селектора отображать 3 самых лучших результатов 
 * 
 */


namespace WindowsFormsApplication1
{
    public partial class RecordsForm : Form
    {
        public RecordsForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = (ComboBox)sender;
            Console.WriteLine(s.SelectedItem);
            var users = Users.Instance.getUserByLevel(s.SelectedItem.ToString());

            dataGridView1.Rows.Clear();

            for (int i = 0; i < 5; i++)
            {
                try
                {
                    dataGridView1.Rows.Add(i, users[i]._name, users[i]._level, users[i]._score);
                }
                catch(IndexOutOfRangeException ex)
                {

                }
            }
        }
    }
}
