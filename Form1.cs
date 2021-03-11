using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerGameWinForms
{
    public partial class Form1 : Form
    {

        private int dsec = 9;
        private int sec = 10;
        private bool gameStarted = false;
        private bool gameOver = false;
        private int score = 0;

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            TimerLabel.ForeColor = Color.White;
            ClickerButton.ForeColor = Color.White;
            ScoreLabel.ForeColor = Color.White;
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            dsec -= 1;
            if(dsec == 0)
            {
                sec -= 1;
                dsec = 9;
            }
            if(sec == 0)
            {                
                GameOver();
                return;
            }

            TimerLabel.Text = sec.ToString("00") + ":" + dsec.ToString("0");
        }

        private void ClickerButton_Click(object sender, EventArgs e)
        {
            if (!gameStarted)
            {
                GameTimer.Start();
                gameStarted = true;
            }

            if (!gameOver)
            {
                score += 1;
                ScoreLabel.Text = score.ToString();
            }            
        }

        private void GameOver()
        {
            GameTimer.Stop();
            gameOver = true;
            ClickerButton.Text = "Game Over";
            TimerLabel.Text = "Click to restart";
        }

        private void GameReset()
        {
            dsec = 9;
            sec = 10;
            score = 0;
            gameStarted = false;
            gameOver = false;
            ClickerButton.Text = "Click me";
            ScoreLabel.Text = "0";
            TimerLabel.Text = "10:0";
        }

        private void TimerLabel_Click(object sender, EventArgs e)
        {
            if (gameStarted)
            {
                GameReset();
            }            
        }
    }
}
