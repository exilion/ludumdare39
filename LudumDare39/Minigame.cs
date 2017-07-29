using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudumDare39
{
    abstract class Minigame
    {
        private string instruction;
        private MobileInterface mobileInterface; 

        public Minigame(MobileInterface mobileInterface)
        {
            this.mobileInterface = mobileInterface;
        }
        
        public string GetInstruction() {
            return instruction;
        }

        abstract public void SetupInterface();
    }
}
