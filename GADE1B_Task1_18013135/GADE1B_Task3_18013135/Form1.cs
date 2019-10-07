using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE1B_Task3_18013135
{
    public partial class Form1 : Form
    {
        GameEngine gameEngine;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            int timer;
            gameEngine.GameLogic(gameEngine.map.ArrUnits);
            lblMap.Text = gameEngine.map.MapDisplay();
            timer = (gameEngine.gameRounds);
            rtxtInfo.Text = gameEngine.OutputString;
            lblTimer.Text = Convert.ToString(timer);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start(); //starts the timer
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();//stops the timer
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameEngine = new GameEngine();
        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }

        private void lblMap_Click(object sender, EventArgs e)
        {

        }

        private void lblTimer_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //map.Save();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //map.Read();
        }
    }
}
