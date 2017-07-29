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
    public partial class Settings : Form
    {
        public int bright, vol;
        public bool bt, wifi;

        public Settings(GameState state)
        {
            InitializeComponent();

            // Disabled for now
            checkBoxBluetooth.Visible = false;
            checkBoxWifi.Visible = false;

            // Read in gamestate
            switch (state.GetBrightness())
            {
                case GameState.Brightness.low:
                    radioBrightLow.Select();
                    break;
                case GameState.Brightness.medium:
                    radioBrightMed.Select();
                    break;
                case GameState.Brightness.high:
                    radioBrightHigh.Select();
                    break;
            }

            switch (state.GetVolume())
            {
                case GameState.Volume.mute:
                    radioVolOff.Select();
                    break;
                case GameState.Volume.low:
                    radioVolLow.Select();
                    break;
                case GameState.Volume.medium:
                    radioVolMed.Select();
                    break;
                case GameState.Volume.high:
                    radioVolHigh.Select();
                    break;
          
            }

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            // Set values to be read from main window to change state.
            if (radioBrightLow.Checked)
            {
                bright = 0;
            }
            else if (radioBrightMed.Checked)
            {
                bright = 1;
            }
            else if (radioBrightHigh.Checked)
            {
                bright = 2;
            }

            if (radioVolOff.Checked)
            {
                vol = 0;
            }
            else if (radioVolLow.Checked)
            {
                vol = 1;
            }
            else if (radioVolMed.Checked)
            {
                vol = 2;
            }
            else if (radioVolHigh.Checked)
            {
                vol = 3;
            }

            Hide();
            return;
        }

    }
}
