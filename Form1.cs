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

        public Form1()
        {
            InitializeComponent();
            GameTimer.Start();
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
                dsec = 0;
                GameTimer.Stop();
            }

            TimerLabel.Text = sec.ToString("00") + ":" + dsec.ToString("0");
        }
    }
}
