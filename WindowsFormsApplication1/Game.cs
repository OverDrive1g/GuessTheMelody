using System;
using System.Windows.Forms;
using GuessTheMelody.Core;

namespace GuessTheMelody
{
    public partial class Game : Form
    {
        Level thisLevel;
        int idCurrentSong = 0;
        Song currentSong;

        int timeLeft = 20;

        int score = 0;

        string nameLevel;

        public Game(int quantityQuestions, String nameLevel)
        {
            this.nameLevel = nameLevel;
            thisLevel = new Level(quantityQuestions);
            InitializeComponent();

            Song[] songs = thisLevel.getSongs();
            loadNextQuestion();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            currentSong.playSong();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            currentSong.pauseSong();
        }

        private void loadNextQuestion()
        {
            if(idCurrentSong < thisLevel.getSongs().Length)
            {
                currentSong = thisLevel.getSongs()[idCurrentSong++];
                currentSong.Init();

                button2.Text = currentSong.answer[0];
                button3.Text = currentSong.answer[1];
                button4.Text = currentSong.answer[2];
                button5.Text = currentSong.answer[3];
                timeLeft = 20;
            }
            else
            {
                endGame();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            label1.Text = timeLeft.ToString();
            if(timeLeft == 0)
            {
                timer1.Stop();
                MessageBox.Show("Вермя вышло!\nПереходим к след вопросу");
                nextQuestion();
            }
        }

        private void nextQuestion()
        {
            currentSong.stopSong();
            loadNextQuestion();
        }

        private void correctQuestion()
        {
            nextQuestion();
            score++;
            label2.Text = "Score: " + score;
            //ta-da
        }

        private void incorrectQuestion()
        {
            nextQuestion();
            //fail
        }

        private void CheckAnswer(object sender, EventArgs e)
        {
            timer1.Stop();
            if(((Button)sender).Text == currentSong.name)
            {
                correctQuestion();
            }
            else
            {
                incorrectQuestion();
            }
        }

        private void endGame()
        {
            Users.Instance.Add(new User(Program.userName, nameLevel, score));
            
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;

            var f = new RecordsForm();
            Hide();
            f.ShowDialog();
            Show();
            Close();
        }
    }
}
