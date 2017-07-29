using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

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

            pictureBoxBattery.Image = Properties.Resources.battery;

            buttonSettings.Enabled = false;
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
                buttonSettings.Enabled = false;
            }
        }

        private void btnStartGame_MouseClick(object sender, MouseEventArgs e)
        {
            status = new GameState();
            gameTimer.Start();
            btnStartGame.Hide();
            buttonSettings.Enabled = true;
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Settings settingsWindow = new Settings(status);
            settingsWindow.ShowDialog();
            switch (settingsWindow.vol)
            {
                case 0:
                    status.SetVolume(GameState.Volume.mute);
                    break;
                case 1:
                    status.SetVolume(GameState.Volume.low);
                    break;
                case 2:
                    status.SetVolume(GameState.Volume.medium);
                    break;
                case 3:
                    status.SetVolume(GameState.Volume.high);
                    break;
            }
            switch (settingsWindow.bright)
            {
                case 0:
                    status.SetBrightness(GameState.Brightness.low);
                    break;
                case 1:
                    status.SetBrightness(GameState.Brightness.medium);
                    break;
                case 2:
                    status.SetBrightness(GameState.Brightness.high);
                    break;
            }

        }

    }
}
