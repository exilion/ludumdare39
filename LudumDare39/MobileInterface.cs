using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LudumDare39
{
    public partial class MobileInterface : Form
    {
        GameState status;
        Timer gameTimer;
        float batteryPercentage;

        public MobileInterface()
        {
            InitializeComponent();

            gameTimer = new Timer();
            gameTimer.Interval = (1000);
            gameTimer.Tick += new EventHandler(gameTimer_Tick);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            status.UpdateBattery();
            batteryPercentage = status.GetBatteryValue()/10;
            textBoxBattery.Text = batteryPercentage.ToString() + "%";
            if (status.GetBatteryValue() == 0)
            {
                gameTimer.Stop();
                btnStartGame.Show();
            }
        }

        private void btnStartGame_MouseClick(object sender, MouseEventArgs e)
        {
            status = new GameState();
            gameTimer.Start();
            btnStartGame.Hide();
        }

    }
}
