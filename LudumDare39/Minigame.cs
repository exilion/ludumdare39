using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LudumDare39
{
    public abstract class Minigame
    {
        protected string minigameDescription;
        protected string minigameName;
        protected UserControl minigameControl;

        public Minigame(string minigameName, string minigameDescription)
        {
            this.minigameName = minigameName;
            this.minigameDescription = minigameDescription;
        }

        public UserControl GetMinigameControl()
        {
            return minigameControl;
        }

        public String GetMinigameDescription()
        {
            return minigameDescription;
        }

        public String GetMinigameName()
        {
            return minigameName;
        }
    }
}
