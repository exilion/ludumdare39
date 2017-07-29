using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LudumDare39.Minigames
{
    public class MinigameContainerClosePopup : Minigame
    {
        public MinigameContainerClosePopup() : base("popups", "Close all the popups, but not the virus scan notifications.")
        {
            base.minigameControl = new MinigameClosePopup();
        }
    }
}
