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

        Image osBar;
        Image background;

        public MobileInterface()
        {
            InitializeComponent();
        }

        private void MobileInterface_Load(object sender, EventArgs e)
        {
            // Init UI   - This should draw the phone 'OS' and display a splash screen on the main screen
            background = new Bitmap(Properties.Resources.menu);
            pictureMenu.Image = background;
        }

        private void buttonStart_click(object sender, EventArgs e)
        {
            // Start game!
            // Hide button
            buttonStart.Hide();


            // Initialise game state
            GameState status = new GameState();


            // Start game


        }


    }
}
